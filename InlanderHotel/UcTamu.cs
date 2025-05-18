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
    public partial class UcTamu : UserControl
    {
        public UcTamu()
        {
            InitializeComponent();
        }

        private void ViewDataTamu()
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tamu", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTamu.DataSource = dt;
            }
        }

        private void ClearForm()
        {
            txtNama.Clear();
            txtAlamat.Clear();
            txtNoTelp.Clear();
            txtEmail.Clear();
        }

        private void UcTamu_Load(object sender, EventArgs e)
        {
            ViewDataTamu();
        }

        private void dgvTamu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTamu.Rows[e.RowIndex];
                txtNama.Text = row.Cells["nama"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat"].Value.ToString();
                txtNoTelp.Text = row.Cells["no_telp"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tamu (nama, alamat, no_telp, email) VALUES (@nama, @alamat, @no_telp, @email)", conn);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                cmd.Parameters.AddWithValue("@no_telp", txtNoTelp.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Data tamu berhasil disimpan!");
            ViewDataTamu();
            ClearForm();
        }

        private void btnUbah_Click_1(object sender, EventArgs e)
        {
            if (dgvTamu.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvTamu.CurrentRow.Cells["id_tamu"].Value);
                Koneksi kon = new Koneksi();
                using (SqlConnection conn = kon.GetConn())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Tamu SET nama=@nama, alamat=@alamat, no_telp=@no_telp, email=@email WHERE id_tamu=@id", conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@no_telp", txtNoTelp.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Data tamu berhasil diperbarui");
                ViewDataTamu();
                ClearForm();
            }
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (dgvTamu.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvTamu.CurrentRow.Cells["id_tamu"].Value);
                DialogResult hasil = MessageBox.Show("Yakin ingin menghapus data tamu ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    Koneksi kon = new Koneksi();
                    using (SqlConnection conn = kon.GetConn())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Tamu WHERE id_tamu=@id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data tamu berhasil dihapus!");
                    ViewDataTamu();
                    ClearForm();
                }
            }
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
