using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Cozumu
{
    internal class Program
    {
        List<Market> list = new List<Market>();
        static void Main(string[] args)
        {
            Program P1 = new Program();

            Market Market1 = new Market("Elma","Meyve", 2.5);

            P1.list.Add(Market1);

            Market Market2 = new Market("Deterjan", "Temizlik", 10.0);

            P1.list.Add(Market2);

            Market Market3 = new Market("Portakal", "Meyve", 3.0);

            P1.list.Add(Market3);

            Market Market4 = new Market("Süt", "Süt Ürünleri", 5.0);

            P1.list.Add(Market4);

            Market Market5 = new Market("Cola", "İçecek", 2.0);

            P1.list.Add(Market5);

            Market Market6 = new Market("Yoğurt", "Süt ürünleri", 4.0);

            P1.list.Add(Market6);

            Market gecici;

            

            for (int i = 0; i < P1.list.Count; i++)
            {
                for (int j = 0; j < P1.list.Count - 1 - i; j++)
                {
                    if (string.Compare(P1.list[j].kategori, P1.list[j + 1].kategori) > -1)
                    {
                        gecici = P1.list[j];
                        P1.list[j] = P1.list[j + 1];
                        P1.list[j + 1] = gecici;
                    }
                }
            }

            for (int i = 0; i < P1.list.Count; i++)
            {
                for (int j = 0; j < P1.list.Count - 1; j++)
                {
                    if (P1.list[j].kategori == P1.list[j + 1].kategori && (P1.list[j].Fiyat > P1.list[j + 1].Fiyat))
                    {
                        gecici = P1.list[j];
                        P1.list[j] = P1.list[j + 1];
                        P1.list[j + 1] = gecici;
                    }
                    
                }
            }

            for (int i = 0; i < P1.list.Count; i++)
            {
                Console.WriteLine(P1.list[i].urunAdi);
                Console.WriteLine(P1.list[i].kategori);
                Console.WriteLine(P1.list[i].Fiyat);
            }

            Console.ReadKey();




        }
    }
}
