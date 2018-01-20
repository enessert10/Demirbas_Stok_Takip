namespace Demirbas_Stok_Takip
{
    partial class D_Sayısı_Arama
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
            this.txtDadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDfiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDtür = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDadet = new System.Windows.Forms.TextBox();
            this.txtDtarih = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDadi
            // 
            this.txtDadi.Location = new System.Drawing.Point(198, 52);
            this.txtDadi.Name = "txtDadi";
            this.txtDadi.Size = new System.Drawing.Size(100, 20);
            this.txtDadi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Demirbaş Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Demirbaş Alım Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Demirbaş Fiyatı :";
            // 
            // txtDfiyat
            // 
            this.txtDfiyat.Location = new System.Drawing.Point(198, 122);
            this.txtDfiyat.Name = "txtDfiyat";
            this.txtDfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtDfiyat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Demirbaş Türü :";
            // 
            // txtDtür
            // 
            this.txtDtür.Location = new System.Drawing.Point(198, 86);
            this.txtDtür.Name = "txtDtür";
            this.txtDtür.Size = new System.Drawing.Size(100, 20);
            this.txtDtür.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Demirbaş Adeti :";
            // 
            // txtDadet
            // 
            this.txtDadet.Location = new System.Drawing.Point(199, 193);
            this.txtDadet.Name = "txtDadet";
            this.txtDadet.Size = new System.Drawing.Size(100, 20);
            this.txtDadet.TabIndex = 8;
            // 
            // txtDtarih
            // 
            this.txtDtarih.Location = new System.Drawing.Point(198, 154);
            this.txtDtarih.Name = "txtDtarih";
            this.txtDtarih.Size = new System.Drawing.Size(101, 20);
            this.txtDtarih.TabIndex = 10;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(147, 240);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(83, 33);
            this.btnAra.TabIndex = 11;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // D_Sayısı_Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 376);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtDtarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDadet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDtür);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDfiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDadi);
            this.Name = "D_Sayısı_Arama";
            this.Text = "D_Sayısı_Arama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDfiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDtür;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDadet;
        private System.Windows.Forms.DateTimePicker txtDtarih;
        private System.Windows.Forms.Button btnAra;
    }
}