﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Python_Öğreniyorum
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cevabınız Yanlış!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cevabınız Yanlış!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cevabınız Yanlış!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cevabınız DOĞRU!");
            this.Hide();
            Form6 form6 = new Form6();
            form6.FormClosed += (s, args) => this.Close();
            form6.Show();
        }
    }
}
