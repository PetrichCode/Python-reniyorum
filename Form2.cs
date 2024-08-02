using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Python_Öğreniyorum
{


    public partial class Form2 : Form
    {
        public static class Utility
        {
            public static string GetRandomQuestion(out bool durum)
            {
                Random rnd = new Random(); int sıra = rnd.Next(0, 3);
                string[] sorular = { "1sayi değişkeni doğru bir değişkendir.", "Değişkenler silinemez.", "'del' Komutu ile değişkenler silinebilir.", "'Kelime' yanlış bir değişkendir. " };
                durum = true;
                switch (sıra)
                {
                    case 0: durum = false; break;
                    case 1: durum = false; break;
                    case 2: durum = true; break;
                    case 3: durum = true; break;
                }
                return sorular[sıra];
            }
        }
        private bool durum;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (durum)
            {
                MessageBox.Show("Doğru Bildin!");
                this.Hide();
                Form3 form3 = new Form3();
                form3.FormClosed += (s, args) => this.Close();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Yanlış Bildin!");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string soru = Utility.GetRandomQuestion(out durum);
            label1.Text = soru;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (durum == false)
            {
                MessageBox.Show("Doğru Bildin!");
                this.Hide();
                Form3 form3 = new Form3();
                form3.FormClosed += (s, args) => this.Close();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Yanlış Bildin!");
            }
        }
    }
}
