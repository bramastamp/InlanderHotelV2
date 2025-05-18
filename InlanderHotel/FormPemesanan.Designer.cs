namespace InlanderHotel
{
    partial class FormPemesanan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPemesanan = new System.Windows.Forms.DataGridView();
            this.cmbTamu = new System.Windows.Forms.ComboBox();
            this.cmbKamar = new System.Windows.Forms.ComboBox();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.txtTotalHarga = new System.Windows.Forms.TextBox();
            this.cmbStatusRes = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPemesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPemesanan
            // 
            this.dgvPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPemesanan.Location = new System.Drawing.Point(230, 219);
            this.dgvPemesanan.Name = "dgvPemesanan";
            this.dgvPemesanan.Size = new System.Drawing.Size(558, 194);
            this.dgvPemesanan.TabIndex = 0;
            this.dgvPemesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPemesanan_CellClick);
            // 
            // cmbTamu
            // 
            this.cmbTamu.FormattingEnabled = true;
            this.cmbTamu.Location = new System.Drawing.Point(230, 32);
            this.cmbTamu.Name = "cmbTamu";
            this.cmbTamu.Size = new System.Drawing.Size(121, 21);
            this.cmbTamu.TabIndex = 1;
            // 
            // cmbKamar
            // 
            this.cmbKamar.FormattingEnabled = true;
            this.cmbKamar.Location = new System.Drawing.Point(493, 32);
            this.cmbKamar.Name = "cmbKamar";
            this.cmbKamar.Size = new System.Drawing.Size(121, 21);
            this.cmbKamar.TabIndex = 2;
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Location = new System.Drawing.Point(230, 93);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtCheckIn.TabIndex = 3;
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Location = new System.Drawing.Point(493, 93);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtCheckOut.TabIndex = 4;
            // 
            // txtTotalHarga
            // 
            this.txtTotalHarga.Location = new System.Drawing.Point(230, 154);
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.Size = new System.Drawing.Size(100, 20);
            this.txtTotalHarga.TabIndex = 5;
            // 
            // cmbStatusRes
            // 
            this.cmbStatusRes.FormattingEnabled = true;
            this.cmbStatusRes.Location = new System.Drawing.Point(493, 154);
            this.cmbStatusRes.Name = "cmbStatusRes";
            this.cmbStatusRes.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusRes.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(230, 180);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(355, 180);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(493, 180);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(618, 180);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.Text = "Check-out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nama Tamu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Check-in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kamar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Check-out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "s.d.";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(713, 180);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormPemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbStatusRes);
            this.Controls.Add(this.txtTotalHarga);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.cmbKamar);
            this.Controls.Add(this.cmbTamu);
            this.Controls.Add(this.dgvPemesanan);
            this.Name = "FormPemesanan";
            this.Text = "FormPemesanan";
            this.Load += new System.EventHandler(this.FormPemesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPemesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPemesanan;
        private System.Windows.Forms.ComboBox cmbTamu;
        private System.Windows.Forms.ComboBox cmbKamar;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.TextBox txtTotalHarga;
        private System.Windows.Forms.ComboBox cmbStatusRes;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReset;
    }
}