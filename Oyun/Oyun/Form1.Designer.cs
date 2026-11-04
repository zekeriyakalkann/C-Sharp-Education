namespace Oyun
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
            kagitPic = new PictureBox();
            tasPic = new PictureBox();
            makasPic = new PictureBox();
            oyuncuPic = new PictureBox();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)kagitPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tasPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)makasPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oyuncuPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // kagitPic
            // 
            kagitPic.Image = Properties.Resources.paper;
            kagitPic.Location = new Point(12, 327);
            kagitPic.Name = "kagitPic";
            kagitPic.Size = new Size(110, 111);
            kagitPic.SizeMode = PictureBoxSizeMode.CenterImage;
            kagitPic.TabIndex = 0;
            kagitPic.TabStop = false;
            kagitPic.Click += pictureBox1_Click;
            // 
            // tasPic
            // 
            tasPic.Image = Properties.Resources.rock;
            tasPic.Location = new Point(128, 327);
            tasPic.Name = "tasPic";
            tasPic.Size = new Size(110, 111);
            tasPic.SizeMode = PictureBoxSizeMode.CenterImage;
            tasPic.TabIndex = 1;
            tasPic.TabStop = false;
            // 
            // makasPic
            // 
            makasPic.Image = Properties.Resources.scissors;
            makasPic.Location = new Point(244, 327);
            makasPic.Name = "makasPic";
            makasPic.Size = new Size(110, 111);
            makasPic.SizeMode = PictureBoxSizeMode.CenterImage;
            makasPic.TabIndex = 2;
            makasPic.TabStop = false;
            // 
            // oyuncuPic
            // 
            oyuncuPic.Location = new Point(80, 72);
            oyuncuPic.Name = "oyuncuPic";
            oyuncuPic.Size = new Size(158, 141);
            oyuncuPic.TabIndex = 3;
            oyuncuPic.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(538, 72);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(158, 141);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Font = new Font("Verdana", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(583, 361);
            button1.Name = "button1";
            button1.Size = new Size(135, 60);
            button1.TabIndex = 5;
            button1.Text = "Başlat";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(104, 34);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 6;
            label1.Text = "OYUNCU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(548, 34);
            label2.Name = "label2";
            label2.Size = new Size(138, 22);
            label2.TabIndex = 7;
            label2.Text = "BİLGİSAYAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 72);
            label3.Name = "label3";
            label3.Size = new Size(61, 22);
            label3.TabIndex = 8;
            label3.Text = "SKOR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 72);
            label4.Name = "label4";
            label4.Size = new Size(61, 22);
            label4.TabIndex = 9;
            label4.Text = "SKOR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 156);
            label5.Name = "label5";
            label5.Size = new Size(64, 22);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(462, 156);
            label6.Name = "label6";
            label6.Size = new Size(64, 22);
            label6.TabIndex = 11;
            label6.Text = "label6";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox5);
            Controls.Add(oyuncuPic);
            Controls.Add(makasPic);
            Controls.Add(tasPic);
            Controls.Add(kagitPic);
            Font = new Font("Verdana", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)kagitPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)tasPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)makasPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)oyuncuPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox kagitPic;
        private PictureBox tasPic;
        private PictureBox makasPic;
        private PictureBox oyuncuPic;
        private PictureBox pictureBox5;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
