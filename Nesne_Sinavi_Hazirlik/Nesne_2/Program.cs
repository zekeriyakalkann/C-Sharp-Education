using System;


namespace Nesne_2
{
    class Hocalar
    {
        public string hoca_adi;

        public void Yaz()
        {
            string hoca_adi = "İrfan ökten";    //Burada farklı tanımlama yaptık, yani sınıfa ait olan hoca_adi değişkenini kullanmadık.
            this.hoca_adi = "Vedat Tümen";      //Burada ise sınıfa ait olan hoca_adi değişkenini this metodu ile seçerek kullanabildik.
            Console.WriteLine(hoca_adi);
            Console.WriteLine(this.hoca_adi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hocalar hocalar = new Hocalar();
            hocalar.Yaz();
            Console.ReadKey();

        }
    }
}

//public const double PI = 3.14; //Const anahtar sözcüğü ile tanımlanan bir değişkeni değiştiremeyiz. PI gibi sabit değerler için kullanılmaktadır.