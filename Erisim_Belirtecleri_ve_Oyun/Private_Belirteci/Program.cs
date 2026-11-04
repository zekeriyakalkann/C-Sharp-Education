using System;

namespace ErisimBelirtecleri
{
    public class Araba
    {
        private string marka; //private erişim belirteci, yalnızca aynı sınıf içinde erişime izin verir.
        private int hız;

        public void BilgiYaz()
        {
            marka = "Toyota";
            hız = 120;
            Console.WriteLine($"Marka: {marka}, Hız: {hız}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba.BilgiYaz();
            Console.ReadKey();
        }
    }
}

