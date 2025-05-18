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
    public partial class FormRingkasan : Form
    {
        public FormRingkasan()
        {
            InitializeComponent();
        }

        private void LoadDashboardData()
        {
            using (SqlConnection conn = new Koneksi().GetConn())
            {
                conn.Open();

                lblTotalKamar.Text = new SqlCommand("SELECT COUNT(*) FROM Kamar", conn).ExecuteScalar().ToString();

                lblTotalTamu.Text = new SqlCommand("SELECT COUNT(*) FROM Tamu", conn).ExecuteScalar().ToString();

                lblKamarTersedia.Text = new SqlCommand("SELECT COUNT(*) FROM Kamar WHERE status='Tersedia'", conn).ExecuteScalar().ToString();

                lblKamarDihuni.Text = new SqlCommand("SELECT COUNT(*) FROM Kamar WHERE status='Dipesan'", conn).ExecuteScalar().ToString();

                lblTotalCheckIn.Text = new SqlCommand("SELECT COUNT(*) FROM Pemesanan WHERE status_res='Dipesan'", conn).ExecuteScalar().ToString();

                lblTotalCheckOut.Text = new SqlCommand("SELECT COUNT(*) FROM Pemesanan WHERE status_res='Selesai'", conn).ExecuteScalar().ToString();

                SqlCommand cmdPemasukan = new SqlCommand(@"
                    SELECT ISNULL(SUM(DATEDIFF(DAY, p.check_in, p.check_out) * k.harga), 0)
                    FROM Pemesanan p
                    JOIN Kamar k ON p.id_kamar = k.id_kamar
                    WHERE p.status_res = 'Selesai'", conn);

                decimal pemasukan = Convert.ToDecimal(cmdPemasukan.ExecuteScalar());
                lblPemasukan.Text = "Rp " + pemasukan.ToString("N0");
            }
        }

        private void LoadChart()
        {
            chartCheckIn.Series.Clear();
            chartCheckIn.Series.Add("Check-In");

            using (SqlConnection conn = new Koneksi().GetConn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    SELECT
                        MONTH(check_in) AS Bulan,
                        COUNT(*) AS Jumlah
                    FROM Pemesanan
                    WHERE YEAR(check_in) = YEAR(GETDATE())
                    GROUP BY MONTH(check_in)
                    ORDER BY BULAN", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int bulan = reader.GetInt32(0);
                    int jumlah = reader.GetInt32(1);
                    chartCheckIn.Series["Check-In"].Points.AddXY(new DateTime(1, bulan, 1).ToString("MMM"), jumlah);
                }

                chartCheckIn.ChartAreas[0].AxisX.Title = "Bulan";
                chartCheckIn.ChartAreas[0].AxisY.Title = "Jumlah Check-in";
            }    
        }

        private void FormRingkasan_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadChart();
        }
    }
}
