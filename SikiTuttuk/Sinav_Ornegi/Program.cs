using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Ornegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Urun> list = new List<Urun>()
            {
                new Urun("F", 75),
                new Urun("A", 100),
                new Urun("B", 100),
                new Urun("C", 100),
                new Urun("D", 100),
                new Urun("F", 100),
                new Urun("E", 100),
                new Urun("E", 450),
                new Urun("B", 250),
                new Urun("C", 120),
                new Urun("D", 300),
                
            };

            //Şimdi önce harfleri sıralayacağız: 

            // a b = -1 b a = 1 a a = 0

            Urun gecici;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j< list.Count-1; j++)
                {

                    if (string.Compare(list[j].ad, list[j+1].ad) > 0)
                    {
                        gecici = list[j];
                        list[j] = list[j+1];
                        list[j + 1] = gecici;
                    }

                    else if (string.Compare(list[j].ad, list[j+1].ad) == 0 && (list[j].fiyat > list[j+1].fiyat))
                    {
                        gecici = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = gecici;
                    }
                }
            }

            foreach (var i in list)
            {
                Console.WriteLine(i.ad + " " + i.fiyat);
            }
            Console.ReadKey();
        }
    }
}
