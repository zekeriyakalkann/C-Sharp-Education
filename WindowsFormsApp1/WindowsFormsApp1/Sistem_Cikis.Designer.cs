namespace WindowsFormsApp1
{
    partial class Sistem_Cikis
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
            this.lblEkranCikti = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEkranCikti
            // 
            this.lblEkranCikti.AutoSize = true;
            this.lblEkranCikti.Location = new System.Drawing.Point(158, 54);
            this.lblEkranCikti.Name = "lblEkranCikti";
            this.lblEkranCikti.Size = new System.Drawing.Size(60, 18);
            this.lblEkranCikti.TabIndex = 0;
            this.lblEkranCikti.Text = "label1";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(161, 238);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(129, 49);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Sistem_Cikis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(472, 356);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblEkranCikti);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Sistem_Cikis";
            this.Text = "Sistem_Cikis";
            this.Load += new System.EventHandler(this.Sistem_Cikis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEkranCikti;
        private System.Windows.Forms.Button btnCikis;
    }
}