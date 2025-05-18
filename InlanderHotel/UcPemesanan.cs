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
    public partial class UcPemesanan : UserControl
    {
        public UcPemesanan()
        {
            InitializeComponent();
            Load += UcPemesanan_Load;
        }

        private void LoadTamu()
        {
            using (var conn = new Koneksi().GetConn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_tamu, nama FROM Tamu", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<int, string> tamuList = new Dictionary<int, string>();
                while (reader.Read())
                {
                    tamuList.Add((int)reader["id_tamu"], reader["nama"].ToString());
                }
                cmbTamu.DataSource = new BindingSource(tamuList, null);
                cmbTamu.DisplayMember = "Value";
                cmbTamu.ValueMember = "Key";
            }
        }

        private void LoadKamar()
        {
            using (var conn = new Koneksi().GetConn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_kamar, no_kamar, tipe_kamar FROM Kamar WHERE status='Tersedia'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<int, string> kamarList = new Dictionary<int, string>();
                while (reader.Read())
                {
                    int id = (int)reader["id_kamar"];
                    string noKamar = reader["no_kamar"].ToString();
                    string tipe = reader["tipe_kamar"].ToString();
                    kamarList.Add(id, $"{noKamar} - {tipe}");
                }
                cmbKamar.DataSource = new BindingSource(kamarList, null);
                cmbKamar.DisplayMember = "Value";
                cmbKamar.ValueMember = "Key";
            }
        }

        private void HeaderGrid()
        {
            if (dgvPemesanan.Columns.Count > 0)
            {
                dgvPemesanan.Columns["id_pemesanan"].HeaderText = "ID";
                dgvPemesanan.Columns["NamaTamu"].HeaderText = "Nama Tamu";
                dgvPemesanan.Columns["Kamar"].HeaderText = "Tipe Kamar";
                dgvPemesanan.Columns["check_in"].HeaderText = "Check-In";
                dgvPemesanan.Columns["check_out"].HeaderText = "Check-Out";
                dgvPemesanan.Columns["total_harga"].HeaderText = "Total Harga";
                dgvPemesanan.Columns["status_res"].HeaderText = "Status";
            }
        }

        private void LoadPemesanan()
        {
            using (var conn = new Koneksi().GetConn())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"SELECT p.id_pemesanan, t.nama AS NamaTamu, k.tipe_kamar AS Kamar, p.check_in, p.check_out, p.total_harga, p.status_res FROM Pemesanan p JOIN Tamu t ON p.id_tamu = t.id_tamu JOIN Kamar k ON p.id_kamar = k.id_kamar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPemesanan.DataSource = dt;
            }
        }

        private void HitungTotalHarga()
        {
            if (cmbKamar.SelectedItem != null)
            {
                int idKamar = ((KeyValuePair<int, string>)cmbKamar.SelectedItem).Key;

                if (dtCheckOut.Value.Date <= dtCheckIn.Value.Date)
                {
                    txtTotalHarga.Text = "0.00";
                    return;
                }

                using (var conn = new Koneksi().GetConn())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT harga FROM Kamar WHERE id_kamar=@id", conn);
                    cmd.Parameters.AddWithValue("@id", idKamar);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        decimal harga = Convert.ToDecimal(result);
                        TimeSpan durasi = dtCheckOut.Value.Date - dtCheckIn.Value.Date;
                        decimal total = harga * (decimal)durasi.TotalDays;
                        txtTotalHarga.Text = total.ToString("F2");
                    }
                }
            }
        }

        private void ClearData()
        {
            if (cmbTamu.Items.Count > 0)
                cmbTamu.SelectedIndex = 0;

            if (cmbKamar.Items.Count > 0)
                cmbKamar.SelectedIndex = 0;

            dtCheckIn.Value = DateTime.Today;
            dtCheckOut.Value = DateTime.Today.AddDays(1);

            cmbStatusRes.SelectedIndex = 0;

            txtTotalHarga.Text = "";

            dgvPemesanan.ClearSelection();
        }


        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (var conn = new Koneksi().GetConn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Pemesanan (id_tamu, id_kamar, check_in, check_out, total_harga, status_res) VALUES (@tamu, @kamar, @in, @out, @total, @status)", conn);

                cmd.Parameters.AddWithValue("@tamu", ((KeyValuePair<int, string>)cmbTamu.SelectedItem).Key);
                cmd.Parameters.AddWithValue("@kamar", ((KeyValuePair<int, string>)cmbKamar.SelectedItem).Key);
                cmd.Parameters.AddWithValue("@in", dtCheckIn.Value.Date);
                cmd.Parameters.AddWithValue("@out", dtCheckOut.Value.Date);
                if (string.IsNullOrWhiteSpace(txtTotalHarga.Text))
                {
                    MessageBox.Show("Total harga belum dihitung.");
                    return;
                }
                cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotalHarga.Text));
                cmd.Parameters.AddWithValue("@status", cmbStatusRes.Text);
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("UPDATE Kamar SET status='Dipesan' WHERE id_kamar=@id", conn);
                cmd2.Parameters.AddWithValue("@id", ((KeyValuePair<int, string>)cmbKamar.SelectedItem).Key);
                cmd2.ExecuteNonQuery();
            }

            LoadPemesanan();
            LoadKamar();
            ClearData();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (dgvPemesanan.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPemesanan.SelectedRows[0].Cells["id_pemesanan"].Value);
                using (var conn = new Koneksi().GetConn())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Pemesanan SET status_res='Selesai' WHERE id_pemesanan=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("UPDATE Kamar SET status='Tersedia' WHERE id_kamar=(SELECT id_kamar FROM Pemesanan WHERE id_pemesanan=@id)", conn);
                    cmd2.Parameters.AddWithValue("@id", id);
                    cmd2.ExecuteNonQuery();
                }

                LoadPemesanan();
                LoadKamar();
            }
        }

        private int GetIdTamuByNama(string nama)
        {
            foreach (KeyValuePair<int, string> item in cmbTamu.Items)
            {
                if (item.Value == nama)
                    return item.Key;
            }
            return -1;
        }

        private int GetIdKamarByTipe(string tipeKamar)
        {
            foreach (KeyValuePair<int, string> item in cmbKamar.Items)
            {
                if (item.Value.Contains(tipeKamar))
                    return item.Key;
            }
            return -1;
        }

        private void dgvPemesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPemesanan.Rows[e.RowIndex];

                cmbTamu.SelectedValue = GetIdTamuByNama(row.Cells["NamaTamu"].Value.ToString());
                cmbKamar.SelectedValue = GetIdKamarByTipe(row.Cells["Kamar"].Value.ToString());
                dtCheckIn.Value = Convert.ToDateTime(row.Cells["check_in"].Value);
                dtCheckOut.Value = Convert.ToDateTime(row.Cells["check_out"].Value);
                txtTotalHarga.Text = row.Cells["total_harga"].Value.ToString();
                cmbStatusRes.Text = row.Cells["status_res"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPemesanan.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPemesanan.SelectedRows[0].Cells["id_pemesanan"].Value);

                using (var conn = new Koneksi().GetConn())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Pemesanan 
                                                      SET id_tamu=@tamu, 
                                                      id_kamar=@kamar, check_in=@in, 
                                                      check_out=@out, total_harga=@total, 
                                                      status_res=@status 
                                                      WHERE id_pemesanan=@id", conn);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@tamu", ((KeyValuePair<int, string>)cmbTamu.SelectedItem).Key);
                    cmd.Parameters.AddWithValue("@kamar", ((KeyValuePair<int, string>)cmbKamar.SelectedItem).Key);
                    cmd.Parameters.AddWithValue("@in", dtCheckIn.Value.Date);
                    cmd.Parameters.AddWithValue("@out", dtCheckIn.Value.Date);
                    cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotalHarga.Text));
                    cmd.Parameters.AddWithValue("@status", cmbStatusRes.Text);
                    cmd.ExecuteNonQuery();
                }

                LoadPemesanan();
                LoadKamar();
                ClearData();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPemesanan.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPemesanan.SelectedRows[0].Cells["id_pemesanan"].Value);

                DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var conn = new Koneksi().GetConn())
                    {
                        conn.Open();

                        SqlCommand getKamarId = new SqlCommand("SELECT id_kamar FROM Pemesanan WHERE id_pemesanan=@id", conn);
                        getKamarId.Parameters.AddWithValue("@id", id);
                        int idKamar = Convert.ToInt32(getKamarId.ExecuteScalar());

                        SqlCommand cmd1 = new SqlCommand("DELETE FROM Pemesanan WHERE id_pemesanan=@id", conn);
                        cmd1.Parameters.AddWithValue("@id", id);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand("UPDATE Kamar SET status='Tersedia' WHERE id_kamar=@idKamar", conn);
                        cmd2.Parameters.AddWithValue("@idKamar", id);
                        cmd2.ExecuteNonQuery();
                    }

                    LoadPemesanan();
                    LoadKamar();
                    ClearData();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void UcPemesanan_Load(object sender, EventArgs e)
        {
            LoadTamu();
            LoadKamar();
            LoadPemesanan();
            HeaderGrid();

            dtCheckOut.ValueChanged += (s, ev) => HitungTotalHarga();
            dtCheckIn.ValueChanged += (s, ev) => HitungTotalHarga();
            cmbKamar.SelectedIndexChanged += (s, ev) => HitungTotalHarga();

            cmbStatusRes.Items.Clear();
            cmbStatusRes.Items.Add("Dipesan");
            cmbStatusRes.Items.Add("Selesai");
            cmbStatusRes.SelectedIndex = 0;
        }
    }
}
