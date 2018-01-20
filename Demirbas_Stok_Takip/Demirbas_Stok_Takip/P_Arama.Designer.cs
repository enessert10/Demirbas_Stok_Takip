namespace Demirbas_Stok_Takip
{
    partial class P_Arama
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
            this.btnPara = new System.Windows.Forms.Button();
            this.lblPsoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblPadi = new System.Windows.Forms.Label();
            this.txtPadi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPara
            // 
            this.btnPara.Location = new System.Drawing.Point(111, 143);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(89, 38);
            this.btnPara.TabIndex = 9;
            this.btnPara.Text = "Personel Ara";
            this.btnPara.UseVisualStyleBackColor = true;
            this.btnPara.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblPsoyad
            // 
            this.lblPsoyad.AutoSize = true;
            this.lblPsoyad.Location = new System.Drawing.Point(66, 98);
            this.lblPsoyad.Name = "lblPsoyad";
            this.lblPsoyad.Size = new System.Drawing.Size(89, 13);
            this.lblPsoyad.TabIndex = 8;
            this.lblPsoyad.Text = "Personel Soyadı :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(157, 95);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 7;
            // 
            // lblPadi
            // 
            this.lblPadi.AutoSize = true;
            this.lblPadi.Location = new System.Drawing.Point(66, 63);
            this.lblPadi.Name = "lblPadi";
            this.lblPadi.Size = new System.Drawing.Size(72, 13);
            this.lblPadi.TabIndex = 6;
            this.lblPadi.Text = "Personel Adı :";
            // 
            // txtPadi
            // 
            this.txtPadi.Location = new System.Drawing.Point(157, 60);
            this.txtPadi.Name = "txtPadi";
            this.txtPadi.Size = new System.Drawing.Size(100, 20);
            this.txtPadi.TabIndex = 5;
            // 
            // P_Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 364);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.lblPsoyad);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblPadi);
            this.Controls.Add(this.txtPadi);
            this.Name = "P_Arama";
            this.Text = "P_Arama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.Label lblPsoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblPadi;
        private System.Windows.Forms.TextBox txtPadi;
    }
}