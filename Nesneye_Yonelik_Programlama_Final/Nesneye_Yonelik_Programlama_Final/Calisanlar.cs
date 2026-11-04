using System;

namespace Nesneye_Yonelik_Programlama_Final
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
            Console.WriteLine("Temel sınıf çağırıldı.");
        }

        public Calisanlar(string mesaj)
        {
            Console.WriteLine(mesaj);
        }




        //public void Bilgi_yaz()
        //{
        //    Console.WriteLine($"Ad:{ad} \nSoyad: {soyad} \nTC No: {tc_no} ");
        //}
    }
}

