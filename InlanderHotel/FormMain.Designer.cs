namespace InlanderHotel
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnRingkasan = new System.Windows.Forms.Button();
            this.btnTamu = new System.Windows.Forms.Button();
            this.btnKamar = new System.Windows.Forms.Button();
            this.btnPemesanan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPemesanan);
            this.panel1.Controls.Add(this.btnKamar);
            this.panel1.Controls.Add(this.btnTamu);
            this.panel1.Controls.Add(this.btnRingkasan);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(207, 1);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(592, 450);
            this.panelContent.TabIndex = 1;
            // 
            // btnRingkasan
            // 
            this.btnRingkasan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRingkasan.FlatAppearance.BorderSize = 0;
            this.btnRingkasan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRingkasan.ForeColor = System.Drawing.Color.White;
            this.btnRingkasan.Location = new System.Drawing.Point(11, 125);
            this.btnRingkasan.Name = "btnRingkasan";
            this.btnRingkasan.Size = new System.Drawing.Size(176, 35);
            this.btnRingkasan.TabIndex = 0;
            this.btnRingkasan.Text = "Ringkasan";
            this.btnRingkasan.UseVisualStyleBackColor = false;
            this.btnRingkasan.Click += new System.EventHandler(this.btnRingkasan_Click);
            // 
            // btnTamu
            // 
            this.btnTamu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnTamu.FlatAppearance.BorderSize = 0;
            this.btnTamu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamu.ForeColor = System.Drawing.Color.White;
            this.btnTamu.Location = new System.Drawing.Point(11, 175);
            this.btnTamu.Name = "btnTamu";
            this.btnTamu.Size = new System.Drawing.Size(176, 35);
            this.btnTamu.TabIndex = 1;
            this.btnTamu.Text = "Tamu";
            this.btnTamu.UseVisualStyleBackColor = false;
            this.btnTamu.Click += new System.EventHandler(this.btnTamu_Click);
            // 
            // btnKamar
            // 
            this.btnKamar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnKamar.FlatAppearance.BorderSize = 0;
            this.btnKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKamar.ForeColor = System.Drawing.Color.White;
            this.btnKamar.Location = new System.Drawing.Point(11, 225);
            this.btnKamar.Name = "btnKamar";
            this.btnKamar.Size = new System.Drawing.Size(176, 35);
            this.btnKamar.TabIndex = 2;
            this.btnKamar.Text = "Kamar";
            this.btnKamar.UseVisualStyleBackColor = false;
            this.btnKamar.Click += new System.EventHandler(this.btnKamar_Click);
            // 
            // btnPemesanan
            // 
            this.btnPemesanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPemesanan.FlatAppearance.BorderSize = 0;
            this.btnPemesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPemesanan.ForeColor = System.Drawing.Color.White;
            this.btnPemesanan.Location = new System.Drawing.Point(11, 275);
            this.btnPemesanan.Name = "btnPemesanan";
            this.btnPemesanan.Size = new System.Drawing.Size(176, 35);
            this.btnPemesanan.TabIndex = 3;
            this.btnPemesanan.Text = "Pemesanan";
            this.btnPemesanan.UseVisualStyleBackColor = false;
            this.btnPemesanan.Click += new System.EventHandler(this.btnPemesanan_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnRingkasan;
        private System.Windows.Forms.Button btnTamu;
        private System.Windows.Forms.Button btnKamar;
        private System.Windows.Forms.Button btnPemesanan;
    }
}