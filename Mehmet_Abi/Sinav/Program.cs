using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Sinav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Urun> liste = new List<Urun>()
            {
                new Urun("B", 150),
                new Urun("A", 100),
                new Urun("B", 100),
                new Urun("A", 750),
                new Urun("D", 300),
                new Urun("A", 250),
                new Urun("C", 100),
                new Urun("D", 100),
                new Urun("C", 75),
                new Urun("D", 50),
            };

            Urun gecici;
            //for (int i = 0; i < liste.Count; i++)
            //{
            //    for (int j = 0; j < liste.Count - 1; j++)
            //    {
            //        if (liste[j].fiyat > liste[j + 1].fiyat)
            //        {
            //            gecici = liste[j];
            //            liste[j] = liste[j + 1];
            //            liste[j + 1] = gecici;
            //        }
            //    }
            //}


            // a b = -1     b a = 1 a a = 0  döner string.Compare metodu için. Yerler değiştirilir ise değer 1 dönmektedir. Bunu da koşul içerisinde belirtmek gerekmektedir.

            for (int i = 0; i < liste.Count; i++)
            {
                for (int j = 0; j < liste.Count - 1; j++)
                {
                    if (string.Compare(liste[j].ad, liste[j + 1].ad) > 0)   //Bu şart sayesinde harflerin yeri değişir.
                    {
                        gecici = liste[j];
                        liste[j] = liste[j + 1];
                        liste[j + 1] = gecici;
                    }
                }
            }

            for (int i = 0; i < liste.Count; i++)
            {
                for (int j = 0; j < liste.Count - 1; j++)
                {
                    if (string.Compare(liste[j].ad, liste[j + 1].ad) == 0 && liste[j].fiyat > liste[j + 1].fiyat)
                    {
                        gecici = liste[j];
                        liste[j] = liste[j + 1];
                        liste[j + 1] = gecici;
                    }
                }
            }

            foreach (var i in liste)
            {
                Console.WriteLine(i.ad + " " + i.fiyat);
            }
            Console.ReadKey();



        }
    }
}
