using System;

namespace ErisimBelirtecleri
{
    public class Araba
    {
        public string marka; //public erişim belirteci, sınıf veya üye değişkenine her yerden erişime izin verir.
        public int hız;

        public void BilgiYaz()
        {
            Console.WriteLine($"Marka: {marka}, Hız: {hız}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba.marka = "Toyota";
            araba.hız = 120;
            araba.BilgiYaz();
            Console.ReadKey();
        }
    }
}

