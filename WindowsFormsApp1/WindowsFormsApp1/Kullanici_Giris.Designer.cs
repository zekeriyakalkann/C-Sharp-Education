namespace WindowsFormsApp1
{
    partial class Kullanici_Giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullaniciGiris = new System.Windows.Forms.TextBox();
            this.txtKullaniciSifreGiris = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Şifre: ";
            // 
            // txtKullaniciGiris
            // 
            this.txtKullaniciGiris.Location = new System.Drawing.Point(171, 112);
            this.txtKullaniciGiris.Name = "txtKullaniciGiris";
            this.txtKullaniciGiris.Size = new System.Drawing.Size(133, 27);
            this.txtKullaniciGiris.TabIndex = 3;
            // 
            // txtKullaniciSifreGiris
            // 
            this.txtKullaniciSifreGiris.Location = new System.Drawing.Point(171, 161);
            this.txtKullaniciSifreGiris.Name = "txtKullaniciSifreGiris";
            this.txtKullaniciSifreGiris.Size = new System.Drawing.Size(133, 27);
            this.txtKullaniciSifreGiris.TabIndex = 4;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(145, 286);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(122, 42);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            // 
            // Kullanici_Giris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(420, 398);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtKullaniciSifreGiris);
            this.Controls.Add(this.txtKullaniciGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Kullanici_Giris";
            this.Text = "Kullanici_Giris";
            this.Load += new System.EventHandler(this.Kullanici_Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullaniciGiris;
        private System.Windows.Forms.TextBox txtKullaniciSifreGiris;
        private System.Windows.Forms.Button btnGiris;
    }
}