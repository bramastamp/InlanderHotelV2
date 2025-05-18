using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InlanderHotel
{
    public partial class FormKamar : Form
    {
        private int selectedKamarId = -1;

        public FormKamar()
        {
            InitializeComponent();
            this.Load += FormKamar_Load;
            flowLayoutPanel1.MouseDown += flowLayoutPanel1_MouseDown;
        }

        private void LoadKamar()
        {
            flowLayoutPanel1.Controls.Clear();

            using (SqlConnection conn = new Koneksi().GetConn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
            SELECT 
                k.id_kamar, k.no_kamar, k.tipe_kamar, k.status, k.harga,
                p.check_in, p.check_out, p.status_res,
                t.nama AS nama_tamu
            FROM Kamar k 
            LEFT JOIN Pemesanan p ON k.id_kamar = p.id_kamar AND p.status_res = 'Dipesan'
            LEFT JOIN Tamu t ON p.id_tamu = t.id_tamu", conn);

                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string statusRes = reader["status_res"]?.ToString();

                    KamarCard card = new KamarCard();
                    card.IdKamar = (int)reader["id_kamar"];
                    card.NoKamar = reader["no_kamar"].ToString();
                    card.Tipe = reader["tipe_kamar"].ToString();
                    card.Harga = reader["harga"].ToString();
                    card.Status = statusRes == "Dipesan" ? "Dipesan" : reader["status"].ToString();

                    if (statusRes == "Dipesan" && reader["check_in"] != DBNull.Value && reader["check_out"] != DBNull.Value)
                    {
                        string namaTamu = reader["nama_tamu"]?.ToString() ?? "Tamu";
                        DateTime checkIn = Convert.ToDateTime(reader["check_in"]);
                        DateTime checkOut = Convert.ToDateTime(reader["check_out"]);

                        card.Penghuni = namaTamu;
                        card.Tanggal = $"{checkIn:dd-MM} s.d. {checkOut:dd-MM}";
                        card.IsDipesan = true;
                        card.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        card.Penghuni = "-";
                        card.Tanggal = "-";
                        card.IsDipesan = false;
                        card.BackColor = Color.White;
                    }

                    card.CardClicked += (s, e) =>
                    {
                        selectedKamarId = card.IdKamar;
                        txtNoKamar.Text = card.NoKamar;
                        cmbTipeKamar.Text = card.Tipe;
                        txtHarga.Text = decimal.Parse(card.Harga).ToString("0");

                        ClearCardSelection();
                        card.BackColor = Color.LightBlue;
                        selectedCard = card;
                    };

                    flowLayoutPanel1.Controls.Add(card);
                }
            }
        }


        private void LoadTipeKamar()
        {
            cmbTipeKamar.Items.Clear();
            cmbTipeKamar.Items.Add("Regular Single");
            cmbTipeKamar.Items.Add("Regular Double");
            cmbTipeKamar.Items.Add("Deluxe Single");
            cmbTipeKamar.Items.Add("Deluxe Double");
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!IsFormValid()) return;

            using (SqlConnection conn = new Koneksi().GetConn())
            {
                conn.Open();
                string query = "INSERT INTO Kamar (no_kamar, tipe_kamar, harga, status) VALUES (@no, @tipe, @harga, 'Tersedia')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@no", txtNoKamar.Text);
                cmd.Parameters.AddWithValue("@tipe", cmbTipeKamar.Text);
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                cmd.ExecuteNonQuery();
            }

            LoadKamar();
            ClearForm();
            MessageBox.Show("Data kamar berhasil disimpan!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedKamarId == -1)
            {
                MessageBox.Show("Pilih kamar terlebih dahulu!");
                return;
            }

            if (!IsFormValid()) return;

            using (SqlConnection conn = new Koneksi().GetConn())
            {
                conn.Open();
                string query = "UPDATE Kamar SET no_kamar=@no, tipe_kamar=@tipe, harga=@harga WHERE id_kamar=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@no", txtNoKamar.Text);
                cmd.Parameters.AddWithValue("@tipe", cmbTipeKamar.Text);
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                cmd.Parameters.AddWithValue("@id", selectedKamarId);
                cmd.ExecuteNonQuery();
            }

            LoadKamar();
            ClearForm();
            MessageBox.Show("Data kamar berhasil diubah!");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedKamarId == -1)
            {
                MessageBox.Show("Pilih kamar yang ingin dihapus!");
                return;
            }

            var result = MessageBox.Show("Yakin ingin menghapus kamar ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new Koneksi().GetConn())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Kamar WHERE id_kamar=@id", conn);
                    cmd.Parameters.AddWithValue("@id", selectedKamarId);
                    cmd.ExecuteNonQuery();
                }

                LoadKamar();
                ClearForm();
                MessageBox.Show("Data kamar berhasil dihapus!");
            }
        }

        private bool IsFormValid()
        {
            if(string.IsNullOrWhiteSpace(txtNoKamar.Text) ||
               string.IsNullOrWhiteSpace(cmbTipeKamar.Text) ||
               string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtHarga.Text, out _))
            {
                MessageBox.Show("Harga harus berupa angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private KamarCard selectedCard = null;

        private void ClearCardSelection()
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is KamarCard card)
                {
                    if (card.IsDipesan)
                        card.BackColor = Color.LightCoral;
                    else
                        card.BackColor = Color.White;
                }
            }
        }

        private void ClearForm()
        {
            txtNoKamar.Clear();
            cmbTipeKamar.SelectedIndex = -1;
            txtHarga.Clear();
            selectedKamarId = -1;
            ClearCardSelection();
        }

        private void FormKamar_Load(object sender, EventArgs e)
        {
            LoadTipeKamar();
            LoadKamar();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void FormKamar_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(ActiveControl is KamarCard))
            {
                ClearForm();
            }
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Control clicked = flowLayoutPanel1.GetChildAtPoint(e.Location);

            while (clicked != null && !(clicked is KamarCard))
            {
                clicked = clicked.Parent;
            }

            if (clicked == null)
            {
                ClearForm();
            }
        }
    }
}
