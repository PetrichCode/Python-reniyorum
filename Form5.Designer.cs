namespace Python_Öğreniyorum
{
    partial class Form5
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
            label1 = new Label();
            soru = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            label1.Text = "Seviye-4";
            label1.Click += label1_Click;
            // 
            // soru
            // 
            soru.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            soru.Location = new Point(12, 74);
            soru.Name = "soru";
            soru.Size = new Size(776, 68);
            soru.TabIndex = 2;
            soru.Text = "Aşağıdaki operatörlerden hangisi kalanı bulma (mod alma, örn: 7’nin 3 ile bölümünden kalanı bulma) ifadesinin karşılığıdır?";
            // 
            // button1
            // 
            button1.Location = new Point(150, 313);
            button1.Name = "button1";
            button1.Size = new Size(61, 61);
            button1.TabIndex = 3;
            button1.Text = "A-)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(294, 313);
            button2.Name = "button2";
            button2.Size = new Size(61, 61);
            button2.TabIndex = 4;
            button2.Text = "B-)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(433, 313);
            button3.Name = "button3";
            button3.Size = new Size(61, 61);
            button3.TabIndex = 5;
            button3.Text = "C-)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(574, 313);
            button4.Name = "button4";
            button4.Size = new Size(61, 61);
            button4.TabIndex = 6;
            button4.Text = "D-)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(150, 249);
            label3.Name = "label3";
            label3.Size = new Size(47, 38);
            label3.TabIndex = 7;
            label3.Text = "/ /";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(433, 249);
            label2.Name = "label2";
            label2.Size = new Size(55, 38);
            label2.TabIndex = 8;
            label2.Text = "<>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(294, 249);
            label4.Name = "label4";
            label4.Size = new Size(40, 38);
            label4.TabIndex = 9;
            label4.Text = "%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(574, 249);
            label5.Name = "label5";
            label5.Size = new Size(49, 38);
            label5.TabIndex = 10;
            label5.Text = "* *";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(soru);
            Controls.Add(label1);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Python Öğreniyorum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label soru;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}