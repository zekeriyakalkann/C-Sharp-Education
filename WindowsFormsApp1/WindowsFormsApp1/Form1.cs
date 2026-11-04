using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public class Calisanlar
        {
            private string kullanici_adi;
            private string kullanici_sifre;

            public Calisanlar(string kullanici_adi, string kullanici_sifre)
            {
                this.Kullanici_adi = kullanici_adi;
                this.Kullanici_sifre = kullanici_sifre;
            }

            public string Kullanici_sifre { get => kullanici_sifre; set => kullanici_sifre = value; }
            public string Kullanici_adi { get => kullanici_adi; set => kullanici_adi = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            Kullanici_Giris kullanici_Giris = new Kullanici_Giris();

            kullanici_Giris.Show();
            if (txtKullaniciAdi.TextLength < 5 && txtKullaniciSifre.TextLength < 5)
            {
                MessageBox.Show("Eksik ya da hatalı bir tuşlama yaptınız. ");
            }


        }
    }
}
