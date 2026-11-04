using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalitim.Siniflar
{
    public class Akademik : Calisanlar //Kalıtım kısmında bu şekilde sadece tek bir kere miras alınmaktadır. Buna dikkat edelim. Eğer 1 den fazla şekilde ekleme yapılacak ise burada interface yani arayüz sayesinde yapabilmekteyiz.
    {
        public string akademik_unvan;
        public int arastirmaci_id;
        public string yoksis_kullanici_adi;
        public int yoksis_sifre;
        public int ders_sayisi;
        public string birimi;
        public string bolumu;
        public Akademik()
        {
        }

        public Akademik(string Akademik_unvan, string Birim, int Ders_sayisi) : base()
        {
            akademik_unvan = Akademik_unvan;
            birimi = Birim;
            ders_sayisi = Ders_sayisi;

            MessageBox.Show($"Unvan: {akademik_unvan} \n Birimi: {birimi} \n Ders sayısı: {ders_sayisi}");
        }
        public void AkademikBilgiYaz()
        {
            MessageBox.Show($"Unvan: {akademik_unvan} \n Birimi: {birimi} \n Bölümü: {bolumu} \n Ders Sayısı: {ders_sayisi}");
        }

        new public string Ekrana_yaz()
        {
            //base.Ekrana_yaz();
            MessageBox.Show("Merhaba Akademisyenler");
            return "Merhabalar Akademisyenler.";
        }


    }
}
