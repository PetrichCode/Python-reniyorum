namespace Python_Öğreniyorum
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            progressBarvirus = new ProgressBar();
            progressBarhero = new ProgressBar();
            label3 = new Label();
            labelsoru = new Label();
            label4 = new Label();
            ipucu = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 0;
            label1.Text = "Seviye-7";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 366);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(518, 349);
            button1.Name = "button1";
            button1.Size = new Size(135, 61);
            button1.TabIndex = 2;
            button1.Text = "Cevap Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(666, 43);
            label2.TabIndex = 4;
            label2.Text = "Açıklama: Virüs sorular yöneltecek eğer sorulara doğru cevap verilirse virüsün canı azalacak.Yanlış cevap verilirse karakterimizin canı azalacak.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(613, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // progressBarvirus
            // 
            progressBarvirus.Location = new Point(24, 120);
            progressBarvirus.Name = "progressBarvirus";
            progressBarvirus.Size = new Size(135, 15);
            progressBarvirus.TabIndex = 6;
            // 
            // progressBarhero
            // 
            progressBarhero.Location = new Point(613, 120);
            progressBarhero.Name = "progressBarhero";
            progressBarhero.Size = new Size(125, 15);
            progressBarhero.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 120);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 8;
            label3.Text = "Soru:";
            // 
            // labelsoru
            // 
            labelsoru.Location = new Point(181, 150);
            labelsoru.Name = "labelsoru";
            labelsoru.Size = new Size(426, 171);
            labelsoru.TabIndex = 9;
            labelsoru.Text = "....";
            labelsoru.Click += labelsoru_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(613, 97);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 10;
            label4.Text = "Kahramanımız:";
            // 
            // ipucu
            // 
            ipucu.AutoSize = true;
            ipucu.Location = new Point(24, 97);
            ipucu.Name = "ipucu";
            ipucu.Size = new Size(44, 20);
            ipucu.TabIndex = 11;
            ipucu.Text = "Virüs:";
            // 
            // button2
            // 
            button2.Location = new Point(722, 12);
            button2.Name = "button2";
            button2.Size = new Size(66, 40);
            button2.TabIndex = 12;
            button2.Text = "Yardım";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(ipucu);
            Controls.Add(label4);
            Controls.Add(labelsoru);
            Controls.Add(label3);
            Controls.Add(progressBarhero);
            Controls.Add(progressBarvirus);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Python Öğreniyorum";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private ProgressBar progressBarvirus;
        private ProgressBar progressBarhero;
        private Label label3;
        private Label labelsoru;
        private Label label4;
        private Label ipucu;
        private Button button2;
    }
}