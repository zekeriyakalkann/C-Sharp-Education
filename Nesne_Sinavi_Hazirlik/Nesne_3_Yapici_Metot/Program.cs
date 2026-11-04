using System;

namespace Nesne_3_Yapici_Metot
{
    class Hoca
    {
        public string hoca_adi = "Vedat Tümen";
        public Hoca()
        {
            this.hoca_adi = "İrfan Ökten";
        }
    }
    class Hocalar
    {
        public string hoca_adi = "Vedat Tümen";
        public Hocalar()
        {
            string hoca_adi = "irfan Ökten";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hoca hoca = new Hoca();
            Console.WriteLine(hoca.hoca_adi);   //Burada ise İrfan Ökten değerini görmemizin sebebi Hoca sınıfı içerisindeki yerel değişken olan hoca_adi değişkenini direk this metodu ile seçerek güncellememizden kaynaklanmaktadır.
            Console.ReadKey();

            //Hocalar hocalar = new Hocalar();
            //Console.WriteLine(hocalar.hoca_adi);    //Burada this metodu ile işaretleme yapmadığımızdan ötürü Vedat Tümen değeri ekranda yazmıştır.
            //Console.ReadKey();
        }
    }
}
