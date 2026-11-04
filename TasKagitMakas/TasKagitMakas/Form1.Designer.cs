namespace TasKagitMakas
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
            components = new System.ComponentModel.Container();
            zamanSay = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // zamanSay
            // 
            zamanSay.Interval = 3000;
            zamanSay.Tick += ZamanSayEvent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.paper;
            pictureBox1.Location = new Point(12, 344);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.rock;
            pictureBox2.Location = new Point(128, 344);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(575, 104);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 117);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.scissors;
            pictureBox4.Location = new Point(244, 344);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(110, 94);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(100, 104);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(135, 117);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 56);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 5;
            label1.Text = "OYUNCU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 56);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 6;
            label2.Text = "BİLGİSAYAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 113);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 7;
            label3.Text = "Skor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 113);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 8;
            label4.Text = "Skor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(263, 177);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 9;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(480, 177);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 10;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(897, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Verdana", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer zamanSay;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
