using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Dersi
{

    class Program
    {
        class Otomobil
        {
            string marka;
            int model;
            bool vites_tipi;

            class Ogrenci   //Class içinde class tanımlanablir bu şekilde bir kullanım mümkündür
            {

            }
            static void Main(string[] args)
            {
                //Sınıf adı nesne adı= new Sınıf adı();     Bu genel olarak nesne oluşturma mantığıdır.
                Otomobil arac1 = new Otomobil();
                arac1.marka = "Chery";
                arac1.model = 2023;
                arac1.vites_tipi = true;

                Console.WriteLine("Aracın markası, modeli ve vites tipi: " + "{0}, {1}, {2}", arac1.marka, arac1.model, arac1.vites_tipi);

                Console.ReadKey();




            }
        }
    }
}
