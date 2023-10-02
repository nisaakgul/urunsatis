namespace urun_fiyat_hesaplama
{
    partial class Form1
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
            this.lblFiyat = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtFiyar = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFiyat.Location = new System.Drawing.Point(31, 44);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(112, 24);
            this.lblFiyat.TabIndex = 0;
            this.lblFiyat.Text = "Birim Fiyatı";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMiktar.Location = new System.Drawing.Point(78, 92);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(65, 24);
            this.lblMiktar.TabIndex = 1;
            this.lblMiktar.Text = "Miktar";
            this.lblMiktar.Click += new System.EventHandler(this.Miktar_Click);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTutar.Location = new System.Drawing.Point(31, 171);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(64, 24);
            this.lblTutar.TabIndex = 2;
            this.lblTutar.Text = "Tutar:";
            // 
            // txtFiyar
            // 
            this.txtFiyar.Location = new System.Drawing.Point(163, 26);
            this.txtFiyar.Multiline = true;
            this.txtFiyar.Name = "txtFiyar";
            this.txtFiyar.Size = new System.Drawing.Size(116, 42);
            this.txtFiyar.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.OliveDrab;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnHesapla.Location = new System.Drawing.Point(302, 25);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(231, 156);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "FİYATI HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(163, 74);
            this.txtMiktar.Multiline = true;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(116, 42);
            this.txtMiktar.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtFiyar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblFiyat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtFiyar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtMiktar;
    }
}

