using System;
using System.Windows.Forms;

namespace Python_Öğreniyorum
{
    public partial class Form4 : Form
    {
        Random rnd = new Random();
        int sıra;
        int sayac = 0;
        string cevap;
        string harf1, harf2, harf3, harf4, harf5 = "";

        public Form4()
        {
            InitializeComponent();
            sıra = rnd.Next(0, 3);
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            labelkafa.Text = "";
            labelust.Text = "";
            labelalt.Text = "";
            labelsol.Text = "";
            labelsag.Text = "";
            labelso_bac.Text = "";
            labelsa_bac.Text = "";
            hatali1.Text = "";
            sayac = 0;
            

            string[] sorular = { "Ondalık Türündeki Değişkenleri Ne İle Tanımlarız?", "String bilgiyi (metinsel) büyük harflere çeviren fonksiyon hangisidir?", "Python kodlama dilinde kullanıcıdan veri alınması gereken durumlarda kullanılması gereken kod aşağıdakilerden hangisi?" };
            soru.Text = sorular[sıra];
            string[] cevaplar = { "float", "upper", "input" };
            cevap = cevaplar[sıra];
        }

        private void buttonharf_Click(object sender, EventArgs e)
        {
            string harf = textBoxharf.Text;

            if (string.IsNullOrEmpty(harf) || harf.Length != 1)
            {
                MessageBox.Show("Lütfen geçerli bir harf girin.");
                return;
            }

            char girilenHarf = harf[0];
            int index = cevap.IndexOf(girilenHarf);

            if (index >= 0)
            {
                if (index == 0)
                {
                    harf1 = girilenHarf.ToString();
                }
                else if (index == 1)
                {
                    harf2 = girilenHarf.ToString();
                }
                else if (index == 2)
                {
                    harf3 = girilenHarf.ToString();
                }
                else if (index == 3)
                {
                    harf4 = girilenHarf.ToString();
                }
                else if (index == 4)
                {
                    harf5 = girilenHarf.ToString();
                }
                yazdir.Text = harf1+"-"+harf2+"-"+harf3+"-" +harf4+ "-"+harf5;
            }
            else
            {
                hatali1.Text += girilenHarf + "-";
                sayac++;
                if (sayac == 1)
                {
                    labelkafa.Text = "0";
                }
                else if (sayac == 2)
                {
                    labelust.Text = "|";

                }
                else if (sayac == 3)
                {
                    labelsol.Text = "/";

                }
                else if (sayac == 4)
                {
                    labelsag.Text = "\\";

                }
                else if (sayac == 5)
                {
                    labelalt.Text = "|";

                }
                else if (sayac == 6)
                {
                    labelso_bac.Text = "/";

                }
                else if (sayac == 7)
                {
                    labelsa_bac.Text = "\\";
                    MessageBox.Show("Çok Fazla Hatalı Deneme Yaptınız!");
                    ResetForm();

                }


            }
        }

        private void buttonkelime_Click(object sender, EventArgs e)
        {
            string kelime = textBoxkelime.Text;
            if (kelime == cevap)
            {
                MessageBox.Show("TEBRİKLER DOĞRU!");
                yazdir.Text = kelime;
                this.Hide();
                Form5 form5 = new Form5();
                form5.FormClosed += (s, args) => this.Close();
                form5.Show();
            }
            else
            {
                MessageBox.Show("HATALI TAHMİN");
                sayac++;
                if (sayac == 1)
                {
                    labelkafa.Text = "0";
                }
                else if (sayac == 2)
                {
                    labelust.Text = "|";

                }
                else if (sayac == 3)
                {
                    labelsol.Text = "/";

                }
                else if (sayac == 4)
                {
                    labelsag.Text = "\\";

                }
                else if (sayac == 5)
                {
                    labelalt.Text = "|";

                }
                else if (sayac == 6)
                {
                    labelso_bac.Text = "/";

                }
                else if (sayac == 7)
                {
                    labelsa_bac.Text = "\\";
                    MessageBox.Show("Çok Fazla Hatalı Deneme Yaptınız!");
                    ResetForm();

                }

            }
        }
    }
}
