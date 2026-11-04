using System;

namespace Isim_Saklama
{

    public class Calisanlar
    {
        public int id;
        public string ad;
        public string soyad;
        public string tc_no;
        protected int yas;
        public int dogum_yili;
        public string dogum_veri;
        public int numara;

        public string Ekrana_yaz()
        {
            Console.WriteLine("Merhaba Çalışanlar" + numara);
            return "Merhabalar Çalışanlar" + numara;
        }
    }

    public class Akademik : Calisanlar
    {
        public string akademik_unvan;
        public int arastirmaci_id;
        public string voksis_kullanici_adi;
        public int voksis_kullanici_sifre;
        public int ders_sayisi;
        public string birimi;
        public string bolumu;
        new public int numara;
        public Akademik(int akd_numara, int cls_numara)
        {
            base.numara = cls_numara;
            numara = akd_numara;
        }
        new public string Ekrana_yaz()  //Temel sınıftaki bir üyeyi türetilmiş bir sınıfta saklamak için new kullanılır.
        {
            //base.Ekrana_yaz();  //Bu komut ile de Calisanlar sınıfındaki Ekrana_yaz metodunu çağırıyoruz.
            Console.WriteLine("Merhaba Akademisyenler" + numara);
            return "Merhabalar Akademisyenler"+ numara;
        }
    }

    class Program
    {
        static void Main()
        {
            //Akademik akd3 = new Akademik();
            //((Calisanlar)akd3).Ekrana_yaz();    //Burada cast işlemi yaparak akademik sınıfından akd3 olarak oluşturulan nesne örneğini Calisanlar sınıfından oluşturulmuş olarak aslında bir nevi göstermiş bulunmaktayız. 
            //Calisanlar akd3 = new Akademik();

            //akd3.Ekrana_yaz();  //Aslında bir yukarıda yapılan cast işlemi direk burada nesne tanımında otomatik olarak yapılmış oldu.

            Akademik akd3 = new Akademik(15,25);

            ((Calisanlar)akd3).Ekrana_yaz();
            akd3.Ekrana_yaz();
            Console.ReadKey();
        }
    }
}