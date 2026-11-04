using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalitim.Siniflar
{
    public class Calisanlar
    {
        public int id;
        public string ad;
        public string soyad;
        public string tc_no;
        public int yas;
        public int dogum_yili;
        public string dogum_yeri;
        public Calisanlar()
        {
            MessageBox.Show("Temel sınıf çağırıldı.");
        }

        public Calisanlar(string mesaj)
        {
            ad = "İrfan";
            soyad = "Ökten";
            tc_no = "12345698745";
            MessageBox.Show($"Mesajınız: {mesaj}");
        }

        public Calisanlar(string Ad, string Soyad, string Tc_no) : base()
        {
            ad = Ad;
            soyad = Soyad;
            tc_no = Tc_no;
            MessageBox.Show($"Ad: {ad} \n Soyad: {soyad} \n TC N0: {tc_no}");
        }

        public Calisanlar(int deneme)
        {
            MessageBox.Show($"Mesajınız: {deneme}");
        }
        public void BilgiYaz()
        {
            MessageBox.Show($"Ad: {ad} \n Soyad: {soyad} \n TC No: {tc_no}");
        }

        public string Ekrana_yaz()
        {
            MessageBox.Show("Merhaba Dünyalılar");
            return "Merhaba Dünyalılar";
        }

    }
}
