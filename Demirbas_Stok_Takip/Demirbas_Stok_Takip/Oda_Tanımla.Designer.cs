namespace Demirbas_Stok_Takip
{
    partial class Oda_Tanımla
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
            this.btnOdaKaydet = new System.Windows.Forms.Button();
            this.lblPsoyad = new System.Windows.Forms.Label();
            this.txtOdaSorumlu = new System.Windows.Forms.TextBox();
            this.lblPadi = new System.Windows.Forms.Label();
            this.txtOdaAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOdaKaydet
            // 
            this.btnOdaKaydet.Location = new System.Drawing.Point(103, 139);
            this.btnOdaKaydet.Name = "btnOdaKaydet";
            this.btnOdaKaydet.Size = new System.Drawing.Size(89, 38);
            this.btnOdaKaydet.TabIndex = 14;
            this.btnOdaKaydet.Text = "Oda Kaydet";
            this.btnOdaKaydet.UseVisualStyleBackColor = true;
            // 
            // lblPsoyad
            // 
            this.lblPsoyad.AutoSize = true;
            this.lblPsoyad.Location = new System.Drawing.Point(58, 94);
            this.lblPsoyad.Name = "lblPsoyad";
            this.lblPsoyad.Size = new System.Drawing.Size(85, 13);
            this.lblPsoyad.TabIndex = 13;
            this.lblPsoyad.Text = "Oda Sorumlusu :";
            // 
            // txtOdaSorumlu
            // 
            this.txtOdaSorumlu.Location = new System.Drawing.Point(149, 91);
            this.txtOdaSorumlu.Name = "txtOdaSorumlu";
            this.txtOdaSorumlu.Size = new System.Drawing.Size(100, 20);
            this.txtOdaSorumlu.TabIndex = 12;
            // 
            // lblPadi
            // 
            this.lblPadi.AutoSize = true;
            this.lblPadi.Location = new System.Drawing.Point(58, 59);
            this.lblPadi.Name = "lblPadi";
            this.lblPadi.Size = new System.Drawing.Size(51, 13);
            this.lblPadi.TabIndex = 11;
            this.lblPadi.Text = "Oda Adı :";
            // 
            // txtOdaAdi
            // 
            this.txtOdaAdi.Location = new System.Drawing.Point(149, 56);
            this.txtOdaAdi.Name = "txtOdaAdi";
            this.txtOdaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtOdaAdi.TabIndex = 10;
            // 
            // Oda_Tanımla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 296);
            this.Controls.Add(this.btnOdaKaydet);
            this.Controls.Add(this.lblPsoyad);
            this.Controls.Add(this.txtOdaSorumlu);
            this.Controls.Add(this.lblPadi);
            this.Controls.Add(this.txtOdaAdi);
            this.Name = "Oda_Tanımla";
            this.Text = "Oda_Tanımla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdaKaydet;
        private System.Windows.Forms.Label lblPsoyad;
        private System.Windows.Forms.TextBox txtOdaSorumlu;
        private System.Windows.Forms.Label lblPadi;
        private System.Windows.Forms.TextBox txtOdaAdi;
    }
}