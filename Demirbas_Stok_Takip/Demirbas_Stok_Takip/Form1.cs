﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demirbas_Stok_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKadi.Text=="admin" && txtSifre.Text=="1234")
            {
                Ana_Sayfa anasayfa= new Ana_Sayfa();
                anasayfa.Show();
                this.Hide();

                
            }
            else
            {
                MessageBox.Show("Hatalı giris yaptınız!");
            }
        }
    }
}
