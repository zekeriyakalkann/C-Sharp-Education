using System;

namespace Nesneye_Yonelik_Programlama_Final
{
    public class Akademik : Calisanlar
    {
        public string akademik_unvan;
        public int arastirmaci_id;
        public string yoksis_kullanici_adi;
        public int yoksis_kullanici_sifre;
        public int ders_sayisi;
        public string birimi;
        public string bolumu;

        public Akademik() : base("Değişkeni mesaj olan temel yapıcı metodumuz çağırıldı.")
        {
            Console.WriteLine("Türetilen sınıf çağırıldı.");
        }
        //public void Akademik_bilgi_yaz()
        //{
        //    Console.WriteLine("Unvan : " + akademik_unvan + "\nBirimi : " + birimi + "\nDers Sayisi : " + ders_sayisi);
        //}
    }
}

