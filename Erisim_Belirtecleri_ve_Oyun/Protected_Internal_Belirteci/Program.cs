using System;

namespace ErişimBelirteçleri
{
    public class Araç
    {
        protected internal string marka; 
        protected internal int hız;
        //protected internal erişim belirteci, yalnızca aynı derleme içinde veya türeyen sınıflarda erişime izin verir.
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

