namespace Windows_Form_Veri_Yapıları
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listbox1 = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(426, 27);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Bilgileri";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 149);
            label2.Name = "label2";
            label2.Size = new Size(205, 22);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci Numarası :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(48, 192);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 2;
            label3.Text = "Ders :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(48, 246);
            label4.Name = "label4";
            label4.Size = new Size(128, 22);
            label4.TabIndex = 3;
            label4.Text = "Ders Kodu: ";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(270, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 25);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Location = new Point(270, 243);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 25);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.Location = new Point(270, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 25);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(48, 312);
            button1.Name = "button1";
            button1.Size = new Size(121, 53);
            button1.TabIndex = 7;
            button1.Text = "Öğrenciye Yeni Ders Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(48, 404);
            button2.Name = "button2";
            button2.Size = new Size(121, 53);
            button2.TabIndex = 8;
            button2.Text = "Derse Yeni Öğrenci Ekle";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(317, 312);
            button3.Name = "button3";
            button3.Size = new Size(130, 53);
            button3.TabIndex = 9;
            button3.Text = "Öğrencinin Dersini Sil";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(317, 404);
            button4.Name = "button4";
            button4.Size = new Size(130, 53);
            button4.TabIndex = 10;
            button4.Text = "Dersteki Öğrenciyi Sil";
            button4.UseVisualStyleBackColor = true;
            // 
            // listbox1
            // 
            listbox1.Anchor = AnchorStyles.Left;
            listbox1.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listbox1.FormattingEnabled = true;
            listbox1.ItemHeight = 17;
            listbox1.Items.AddRange(new object[] { "Dersteki Öğrencilerin Numaraya Göre Sıralanışı : " });
            listbox1.Location = new Point(647, 145);
            listbox1.Name = "listbox1";
            listbox1.Size = new Size(334, 123);
            listbox1.TabIndex = 11;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Left;
            listBox2.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Items.AddRange(new object[] { "Öğrencinin Aldığı Derslerin Koduna Göre Sıralanışı : " });
            listBox2.Location = new Point(647, 312);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(334, 123);
            listBox2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1145, 506);
            Controls.Add(listBox2);
            Controls.Add(listbox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listbox1;
        private ListBox listBox2;
    }
}
