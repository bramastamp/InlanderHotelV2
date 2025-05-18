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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ShowUserControl(new UcRingkasan());
        }

        private void LoadUserControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        private void ShowUserControl(UserControl uc)
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

            button.BackColor = Color.FromArgb(58, 58, 58); // warna aktif
            activeButton = button;
        }
    }
}
