namespace InlanderHotel
{
    partial class UcTamu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTamu = new System.Windows.Forms.DataGridView();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTamu
            // 
            this.dgvTamu.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvTamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTamu.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvTamu.Location = new System.Drawing.Point(34, 176);
            this.dgvTamu.Name = "dgvTamu";
            this.dgvTamu.Size = new System.Drawing.Size(530, 192);
            this.dgvTamu.TabIndex = 25;
            this.dgvTamu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTamu_CellClick_1);
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.BackColor = System.Drawing.SystemColors.Info;
            this.btnBersihkan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBersihkan.Location = new System.Drawing.Point(296, 134);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(75, 23);
            this.btnBersihkan.TabIndex = 24;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = false;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.Info;
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHapus.Location = new System.Drawing.Point(201, 134);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 23;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.SystemColors.Info;
            this.btnUbah.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUbah.Location = new System.Drawing.Point(394, 134);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 22;
            this.btnUbah.Text = "Edit";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click_1);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Info;
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSimpan.Location = new System.Drawing.Point(489, 134);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 21;
            this.btnSimpan.Text = "Tambah";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(391, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(391, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "No. Telepon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(198, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(198, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nama";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEmail.Location = new System.Drawing.Point(394, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.BackColor = System.Drawing.SystemColors.Info;
            this.txtNoTelp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNoTelp.Location = new System.Drawing.Point(394, 45);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(170, 20);
            this.txtNoTelp.TabIndex = 15;
            // 
            // txtAlamat
            // 
            this.txtAlamat.BackColor = System.Drawing.SystemColors.Info;
            this.txtAlamat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtAlamat.Location = new System.Drawing.Point(201, 94);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(170, 20);
            this.txtAlamat.TabIndex = 14;
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.SystemColors.Info;
            this.txtNama.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNama.Location = new System.Drawing.Point(201, 45);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(170, 20);
            this.txtNama.TabIndex = 13;
            // 
            // UcTamu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.dgvTamu);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNoTelp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "UcTamu";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.UcTamu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTamu;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNama;
    }
}
