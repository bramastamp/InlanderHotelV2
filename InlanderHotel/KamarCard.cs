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
    public partial class KamarCard : UserControl
    {
        public KamarCard()
        {
            InitializeComponent();
        }

        public string NoKamar
        {
            get => lblNoKamar.Text;
            set => lblNoKamar.Text = value;
        }

        public string Tipe
        {
            get => lblTipe.Text;
            set => lblTipe.Text = value;
        }

        public string Status
        { 
            get => lblStatus.Text;
            set => lblStatus.Text = value;
        }

        public string Penghuni
        {
            get => lblPenghuni.Text;
            set => lblPenghuni.Text = value;
        }

        public string Tanggal
        {
            get => lblTanggal.Text;
            set => lblTanggal.Text = value;
        }

        public string Harga { get; set; }

        public int IdKamar { get; set; }

        public bool IsDipesan { get; set; }

        public event EventHandler CardClicked;

        private void KamarCard_Click(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, e);
        }

        private void ApplyClickHandlerToAllControls(Control ctrl)
        {
            ctrl.Click += KamarCard_Click;
            foreach (Control child in ctrl.Controls)
                ApplyClickHandlerToAllControls(child);
        }

        private void KamarCard_Load(object sender, EventArgs e)
        {
            ApplyClickHandlerToAllControls(this);
        }
    }
}
