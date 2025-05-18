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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKoneksi_Click(object sender, EventArgs e)
        {
            Koneksi kon = new Koneksi();
            using (SqlConnection conn = kon.GetConn())
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Koneksi ke database BERHASIL!", 
                                    "Sukses", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Koneksi GAGAL: " + ex.Message, 
                                    "GAGAL", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
