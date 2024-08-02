using System;
using System.Windows.Forms;

namespace Python_Öğreniyorum
{
    public partial class Form6 : Form
    {
        private string cevap="";
        private int bittimi=0;
        public Form6()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeButtons()
        {
        }

        private void SolButon_Click(object sender, EventArgs e)
        {
        }

        private void SagButon_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cevap = buttondegildir.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cevap = buttonesitmi.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cevap = buttonesitle.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cevap = buttondongu.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cevap = buttonkosul.Text;
        }

        private void buttonesitle_Click(object sender, EventArgs e)
        {
            if (cevap == buttonesitle.Text)
            {
                label12.Text = "3.";
                bittimi++;
            }
            else
            {
                MessageBox.Show("Yanlış Tahmin Yaptınız.");
            }
            if (bittimi == 5)
            {
                MessageBox.Show("Tebrikler Hepsini Doğru Tamamladınız.");
                this.Hide();
                Form8 form8 = new Form8();
                form8.FormClosed += (s, args) => this.Close();
                form8.Show();
            }
        }

        private void buttondongu_Click(object sender, EventArgs e)
        {
            if (cevap == buttondongu.Text)
            {
                label13.Text = "4.";
                bittimi++;
            }
            else
            {
                MessageBox.Show("Yanlış Tahmin Yaptınız.");
            }
            if (bittimi == 5)
            {
                MessageBox.Show("Tebrikler Hepsini Doğru Tamamladınız.");
                this.Hide();
                Form8 form8 = new Form8();
                form8.FormClosed += (s, args) => this.Close();
                form8.Show();
            }

        }

        private void buttonkosul_Click(object sender, EventArgs e)
        {
            if (cevap == buttonkosul.Text)
            {
                label14.Text = "5.";
                bittimi++;
            }
            else
            {
                MessageBox.Show("Yanlış Tahmin Yaptınız.");
            }
            if (bittimi == 5)
            {
                MessageBox.Show("Tebrikler Hepsini Doğru Tamamladınız.");
                this.Hide();
                Form8 form8 = new Form8();
                form8.FormClosed += (s, args) => this.Close();
                form8.Show();
            }
        }

        private void buttondegildir_Click(object sender, EventArgs e)
        {
            if (cevap == buttondegildir.Text)
            {
                label15.Text = "1.";
                bittimi++;
            }
            else
            {
                MessageBox.Show("Yanlış Tahmin Yaptınız.");
            }
            if (bittimi == 5)
            {
                MessageBox.Show("Tebrikler Hepsini Doğru Tamamladınız.");
                this.Hide();
                Form8 form8 = new Form8();
                form8.FormClosed += (s, args) => this.Close();
                form8.Show();
            }
        }

        private void buttonesitmi_Click(object sender, EventArgs e)
        {
            if (cevap == buttonesitmi.Text)
            {
                label16.Text = "2.";
                bittimi++;
            }
            else
            {
                MessageBox.Show("Yanlış Tahmin Yaptınız.");
            }
            if (bittimi == 5)
            {
                MessageBox.Show("Tebrikler Hepsini Doğru Tamamladınız.");
                this.Hide();
                Form8 form8 = new Form8();
                form8.FormClosed += (s, args) => this.Close();
                form8.Show();
            }
        }
    }
}
