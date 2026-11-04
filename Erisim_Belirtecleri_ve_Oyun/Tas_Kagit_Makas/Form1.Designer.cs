namespace Tas_Kagit_Makas
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
            picTas = new PictureBox();
            picKagit = new PictureBox();
            picMakas = new PictureBox();
            picOyuncu = new PictureBox();
            btnBaslat = new Button();
            picBilgisayar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblOyuncuSkor = new Label();
            lblBilgisayarSkor = new Label();
            ((System.ComponentModel.ISupportInitialize)picTas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picKagit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMakas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOyuncu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBilgisayar).BeginInit();
            SuspendLayout();
            // 
            // picTas
            // 
            picTas.Image = Properties.Resources.rock;
            picTas.Location = new Point(12, 331);
            picTas.Name = "picTas";
            picTas.Size = new Size(113, 107);
            picTas.SizeMode = PictureBoxSizeMode.CenterImage;
            picTas.TabIndex = 0;
            picTas.TabStop = false;
            picTas.Click += picTas_Click;
            // 
            // picKagit
            // 
            picKagit.Image = Properties.Resources.paper;
            picKagit.Location = new Point(131, 331);
            picKagit.Name = "picKagit";
            picKagit.Size = new Size(116, 107);
            picKagit.SizeMode = PictureBoxSizeMode.CenterImage;
            picKagit.TabIndex = 1;
            picKagit.TabStop = false;
            picKagit.Click += picKagit_Click;
            // 
            // picMakas
            // 
            picMakas.Image = Properties.Resources.scissors;
            picMakas.Location = new Point(253, 331);
            picMakas.Name = "picMakas";
            picMakas.Size = new Size(109, 107);
            picMakas.SizeMode = PictureBoxSizeMode.CenterImage;
            picMakas.TabIndex = 2;
            picMakas.TabStop = false;
            picMakas.Click += picMakas_Click;
            // 
            // picOyuncu
            // 
            picOyuncu.Image = Properties.Resources.paper;
            picOyuncu.Location = new Point(140, 108);
            picOyuncu.Name = "picOyuncu";
            picOyuncu.Size = new Size(114, 110);
            picOyuncu.SizeMode = PictureBoxSizeMode.CenterImage;
            picOyuncu.TabIndex = 3;
            picOyuncu.TabStop = false;
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(467, 358);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(112, 55);
            btnBaslat.TabIndex = 5;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // picBilgisayar
            // 
            picBilgisayar.Image = Properties.Resources.paper;
            picBilgisayar.Location = new Point(467, 108);
            picBilgisayar.Name = "picBilgisayar";
            picBilgisayar.Size = new Size(114, 110);
            picBilgisayar.SizeMode = PictureBoxSizeMode.CenterImage;
            picBilgisayar.TabIndex = 6;
            picBilgisayar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 78);
            label1.Name = "label1";
            label1.Size = new Size(74, 18);
            label1.TabIndex = 7;
            label1.Text = "Oyuncu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(467, 78);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 8;
            label2.Text = "Bilgisayar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 108);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 9;
            label3.Text = "Skor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 108);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 10;
            label4.Text = "Skor";
            // 
            // lblOyuncuSkor
            // 
            lblOyuncuSkor.AutoSize = true;
            lblOyuncuSkor.Location = new Point(271, 185);
            lblOyuncuSkor.Name = "lblOyuncuSkor";
            lblOyuncuSkor.Size = new Size(20, 18);
            lblOyuncuSkor.TabIndex = 11;
            lblOyuncuSkor.Text = "''";
            // 
            // lblBilgisayarSkor
            // 
            lblBilgisayarSkor.AutoSize = true;
            lblBilgisayarSkor.Location = new Point(386, 185);
            lblBilgisayarSkor.Name = "lblBilgisayarSkor";
            lblBilgisayarSkor.Size = new Size(20, 18);
            lblBilgisayarSkor.TabIndex = 12;
            lblBilgisayarSkor.Text = "''";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBilgisayarSkor);
            Controls.Add(lblOyuncuSkor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picBilgisayar);
            Controls.Add(btnBaslat);
            Controls.Add(picOyuncu);
            Controls.Add(picMakas);
            Controls.Add(picKagit);
            Controls.Add(picTas);
            Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picTas).EndInit();
            ((System.ComponentModel.ISupportInitialize)picKagit).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMakas).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOyuncu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBilgisayar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picTas;
        private PictureBox picKagit;
        private PictureBox picMakas;
        private PictureBox picOyuncu;
        private Button btnBaslat;
        private PictureBox picBilgisayar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblOyuncuSkor;
        private Label lblBilgisayarSkor;
    }
}
