using System;

namespace ErisimBelirtecleri
{
    public class Araç
    {
        protected string marka; //protected erişim belirteci, yalnızca aynı sınıf veya ondan türeyen sınıflar içinde erişime izin verir
        protected int hız;
    }

    public class Araba : Araç
    {
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
        }
    }
}

