using System;

namespace Base
{


    public class Calisanlar
    {
        public int id;
        public string ad;
        public string soyad;
        public string tc_no;
        public int yas;
        public int dogum_yili;
        public string dogum_veri;

        public Calisanlar()
        {
            ad = "İrfan";
            soyad = "Ökten";
            tc_no = "12345678954";

            Console.WriteLine("En temel sınıf çağırıldı.");
        }

        public Calisanlar(string AD, string SOYAD, string TC_no)
        {
            ad = AD;
            soyad = SOYAD;
            tc_no = TC_no;
            Console.WriteLine("Ad : " + ad + "\nSoyad : " + soyad + "\nT.C. No : " + tc_no);
        }

    }

    public class Akademik : Calisanlar
    {
        public string akademik_unvan;
        public int arastirmaci_id;
        public int ders_sayisi;
        public string birimi;
        public string bolumu;

        public Akademik()
        {
        }

        public Akademik(string Akademik_unvan, string Birim, int Ders_sayisi) : base()// Base komutu bu şekilde kullanıldığında varsayılan yapıcı metodu çağırır. Başka bir yapıcı metot çağırılması için base in parantezleri içerisine o yordamın değişkenleri yazılmalıdır.
        {
            akademik_unvan = Akademik_unvan;
            birimi = Birim;
            ders_sayisi = Ders_sayisi;

            Console.WriteLine("Unvan : " + akademik_unvan + "\nBirim : " + birimi + "\nDers Sayisi : " + ders_sayisi);
        }
    }

    public class Dersler: Akademik
    {
        public string ders_adi = "Nesneye Yönelik Programlama";
        public int ders_saati;
        public int ders_id;
        public Dersler() : base("Dr. Öğr. Üyesi", "Mühendislik fakültesi", 8) 
        {
            Console.WriteLine("Ders Adı :" + ders_adi + "\nDers hocası : " + ad);
        }
    }

    class Program
    {
        static void Main()
        {
            Dersler d1 = new Dersler();
            Console.ReadKey();
        }
    }
}