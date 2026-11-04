using System;

namespace Nesne_11_Internal
{
    class ad
    {
        internal string isim = "Hüseyin ELÇİ sakattır.";
        // Etkin projeye ait sınıflardan erişilebilir, onların dışından erişilemez.
    }
    class Program
    {
        static void Main(string[] args)
        {
            var isim = new ad();
            Console.WriteLine(isim.isim);
            Console.ReadKey();
        }
    }
}
