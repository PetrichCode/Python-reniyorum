using System;
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
    public partial class Form3 : Form
    {
        Random rnd = new Random();
        int sıra;

        public static class Utility
        {
        }

        public Form3()
        {
            InitializeComponent();
            sıra = rnd.Next(0, 3); 
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] sorular = { "X Değişkenini stringe çevir", "Ekrana 'Elma' yazdır", "Arabalar dizisindeki eleman sayısını yazdır:" };
            label3.Text = sorular[sıra]; 

            if (sıra == 0)
            {
                textBox1.MaxLength = 3;
                label2.Text = "x=5";
                label4.Text = "x = ";
                label5.Text = "(x)";
            }
            else if (sıra == 1)
            {
                textBox1.MaxLength = 5;
                label2.Text = "x='Elma'";
                label4.Text = "";
                label5.Text = "(x)";
            }
            else if (sıra == 2)
            {
                textBox1.MaxLength = 3;
                label2.Text = "arabalar={'ford','fiat','nissan'}";
                label4.Text = "x = ";
                label5.Text = "(arabalar)";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cevaplar = { "str", "print", "len" };
            string cevap = textBox1.Text.Trim().ToLower();
            if (cevaplar[sıra] == cevap)
            {
                MessageBox.Show("Cevabın Doğru!");
                this.Hide();
                Form4 form4 = new Form4();
                form4.FormClosed += (s, args) => this.Close();
                form4.Show();
            }
            else
            {
                MessageBox.Show("Cevabın Yanlış!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
