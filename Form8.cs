using System;
using System.Windows.Forms;

namespace Python_Öğreniyorum
{
    public partial class Form8 : Form
    {
    
        string[] aciklama = {
            "'range()' Fonksiyonu, başlangıç ve bitiş değerlerini belirleyebildiğimiz bir liste oluşturur.",
            "Metinsel ifadelerde,tüm metnin harflerini büyütmek için 'upper', tüm harflerini küçültmek için 'lower' kullanılır",
            "Bir ifadeyi sayısal bir ifadeye çevirmek için 'int', metinsel bir ifadeye çevirmek için 'str' kullanılır.",
            "Bir sayının üssünü almak istediğimizde '**' işaretini kullanırız."
        };
        string[] sorular = {
            "For döngüsünde sayı döngüsünü belirlemek için hangi komut kullanılır?",
            "Metinsel bir ifadenin tüm karakterlerini küçük harf yapmak için hangi komut kullanılır?",
            "Metinsel bir ifadeyi sayısal bir ifadeye çevirmek için hangi komut kullanılmaktadır?",
            "Üs alma (örn: 2’nin küpü) ifadesinin karşılığı nedir?"
        };
        string[] cevaplar = { "range", "lower", "int", "**" };

        int currentQuestion = 0; 

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
       
            progressBarvirus.Minimum = 0;
            progressBarvirus.Maximum = 100;
            progressBarvirus.Value = 100;

            progressBarhero.Minimum = 0;
            progressBarhero.Maximum = 100;
            progressBarhero.Value = 100;

         
            labelsoru.Text = sorular[currentQuestion];
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string userAnswer = textBox1.Text.Trim();

            if (userAnswer.Equals(cevaplar[currentQuestion], StringComparison.OrdinalIgnoreCase))
            {
                
                progressBarvirus.Value = Math.Max(progressBarvirus.Value - 25, 0);
            }
            else
            {
            
                progressBarhero.Value = Math.Max(progressBarhero.Value - 25, 0);
            }

            if (progressBarvirus.Value == 0)
            {
                MessageBox.Show("Tebrikler, kazandınız!");
                this.Hide();
                Form7 form7 = new Form7();
                form7.FormClosed += (s, args) => this.Close();
                form7.Show();
            }
            else if (progressBarhero.Value == 0)
            {
                MessageBox.Show("Kaybettiniz.");
                ResetGame();
            }
            else
            {
           
                currentQuestion = (currentQuestion + 1) % sorular.Length;
                labelsoru.Text = sorular[currentQuestion];

            }
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aciklama[currentQuestion], "İpucu");
        }

        private void ResetGame()
        {
          
            progressBarvirus.Value = 100;
            progressBarhero.Value = 100;
            currentQuestion = 0;
            labelsoru.Text = sorular[currentQuestion];
        }

        private void labelsoru_Click(object sender, EventArgs e)
        {

        }
    }
}
