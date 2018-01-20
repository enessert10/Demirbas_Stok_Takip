namespace Demirbas_Stok_Takip
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
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.lblKadi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(124, 45);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(100, 20);
            this.txtKadi.TabIndex = 0;
            // 
            // lblKadi
            // 
            this.lblKadi.AutoSize = true;
            this.lblKadi.Location = new System.Drawing.Point(53, 48);
            this.lblKadi.Name = "lblKadi";
            this.lblKadi.Size = new System.Drawing.Size(70, 13);
            this.lblKadi.TabIndex = 1;
            this.lblKadi.Text = "Kullanıcı Adı :";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(53, 83);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(34, 13);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre :";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(124, 80);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 2;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(84, 137);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(78, 29);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblKadi);
            this.Controls.Add(this.txtKadi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.Label lblKadi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
    }
}

