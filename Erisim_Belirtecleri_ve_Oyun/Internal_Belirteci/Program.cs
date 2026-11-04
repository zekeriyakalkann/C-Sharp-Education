using System;

namespace ErişimBelirteçleri
{
    internal class Araba
    {
        internal string marka; //internal erişim belirteci, yalnızca aynı derleme (assembly) içinde erişime izin verir.
        internal int hız;

        internal void BilgiYaz()
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
