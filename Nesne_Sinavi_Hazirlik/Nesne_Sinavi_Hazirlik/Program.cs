    using System;

namespace Nesne_Sinavi_Hazirlik
{
    class Arac
    {
        public string marka;
        public static int model;
        public static bool vites_tipi;
        //Static ile değişken tanımlarımızı yaptığımızda nesne oluşturmadan sinif_adi.degisken_adi = ....; şeklinde tanımlama yapabilmekteyiz.
        //Static öğelere sınıf işaretçisiyle, static olmayan öğelere de nesne işaretçisiyle erişilir.
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Arac1 = new Arac();

            Arac1.marka = "Toşaf";
            Arac.model = 1997;
            Arac.vites_tipi = false;
            

            Console.WriteLine($"Marka: {Arac1.marka}, Model: {Arac.model}, Vites Tipi: {Arac.vites_tipi}");
            Console.ReadKey();

        }
    }
}
