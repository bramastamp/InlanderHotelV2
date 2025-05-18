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
using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace InlanderHotel
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void StyleRoundedButton(Button btn, int radius, Color borderColor)
        {
            // Buat bentuk rounded
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btn.Region = new Region(path);

            // Style tombol
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = borderColor;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            btnRingkasan.PerformClick(); // Kuganti biar buttonnya auto fokus bla bla blaa
            StyleRoundedButton(btnKunciApplikasi, 4, Color.White); // dont worry about these
            StyleRoundedButton(btnLogout, 4, Color.White);
        }

        private void LoadUserControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        private void btnRingkasan_Click(object sender, EventArgs e)
        {
            ActivateButton(btnRingkasan);
            LoadUserControl(new UcRingkasan());
        }

        private void btnTamu_Click(object sender, EventArgs e)
        {
            ActivateButton(btnTamu);
            LoadUserControl(new UcTamu());
        }

        private void btnKamar_Click(object sender, EventArgs e)
        {
            ActivateButton(btnKamar);
            LoadUserControl(new UcKamar());
        }

        private void btnPemesanan_Click(object sender, EventArgs e)
        {
            ActivateButton(btnPemesanan);
            LoadUserControl(new UcPemesanan());
        }

        private Button activeButton = null;

        private void ActivateButton(Button button)
        {
            if (activeButton != null)
                activeButton.BackColor = Color.FromArgb(38, 38, 38); // warna default

            button.BackColor = Color.FromArgb(69, 69, 69); // warna aktif
            activeButton = button;
        }
    }
}
