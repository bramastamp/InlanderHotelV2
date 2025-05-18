namespace InlanderHotel
{
    partial class KamarCard
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
            this.lblNoKamar = new System.Windows.Forms.Label();
            this.lblTipe = new System.Windows.Forms.Label();
            this.lblPenghuni = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoKamar
            // 
            this.lblNoKamar.AutoSize = true;
            this.lblNoKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoKamar.Location = new System.Drawing.Point(10, 12);
            this.lblNoKamar.Name = "lblNoKamar";
            this.lblNoKamar.Size = new System.Drawing.Size(31, 20);
            this.lblNoKamar.TabIndex = 0;
            this.lblNoKamar.Text = "No";
            // 
            // lblTipe
            // 
            this.lblTipe.AutoSize = true;
            this.lblTipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipe.Location = new System.Drawing.Point(83, 67);
            this.lblTipe.Name = "lblTipe";
            this.lblTipe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTipe.Size = new System.Drawing.Size(51, 12);
            this.lblTipe.TabIndex = 1;
            this.lblTipe.Text = "Tipe Kamar";
            this.lblTipe.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblPenghuni
            // 
            this.lblPenghuni.AutoSize = true;
            this.lblPenghuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenghuni.Location = new System.Drawing.Point(10, 67);
            this.lblPenghuni.Name = "lblPenghuni";
            this.lblPenghuni.Size = new System.Drawing.Size(28, 12);
            this.lblPenghuni.TabIndex = 2;
            this.lblPenghuni.Text = "Tamu";
            this.lblPenghuni.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(83, 18);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTanggal.Size = new System.Drawing.Size(37, 12);
            this.lblTanggal.TabIndex = 3;
            this.lblTanggal.Text = "Tanggal";
            this.lblTanggal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(60, 40);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(32, 12);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KamarCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblPenghuni);
            this.Controls.Add(this.lblTipe);
            this.Controls.Add(this.lblNoKamar);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KamarCard";
            this.Size = new System.Drawing.Size(159, 95);
            this.Load += new System.EventHandler(this.KamarCard_Load);
            this.Click += new System.EventHandler(this.KamarCard_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoKamar;
        private System.Windows.Forms.Label lblTipe;
        private System.Windows.Forms.Label lblPenghuni;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblStatus;
    }
}
