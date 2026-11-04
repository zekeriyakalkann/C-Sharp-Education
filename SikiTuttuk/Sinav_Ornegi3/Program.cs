using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Ornegi3
{
    public class Calisan
    {
        public string ad;
        public int numara;
        public string departman;
        public Calisan(string ad , int numara, string departman) 
        {
            this.ad = ad;
            this.numara = numara;
            this.departman = departman;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Calisan> list = new List<Calisan>()
            {
                new Calisan("Ahmet", 201, "Muhasebe"),
                new Calisan("Elif", 202, "Pazarlama"),
                new Calisan("Burak", 203, "Muhasebe"),
                new Calisan("Deniz", 204, "Muhasebe"),
                new Calisan("Cem", 205, "Ticaret"),
            };

            // a b = -1 b a = 1 a a = 0

            Calisan gecici;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count-1; j++)
                {
                    if (string.Compare(list[j].departman, list[j+1].departman)>0)
                    {
                        gecici = list[j];
                        list[j] = list[j+1];
                        list[j+1] = gecici;
                    }
                    else if (string.Compare(list[j].departman, list[j+1].departman) == 0 && (list[j].numara > list[j+1].numara))
                    {
                        gecici = list[j];
                        list[j] = list[j+1];
                        list[j + 1] = gecici;
                    }
                }

                Console.WriteLine("Çalışan listesi aşağıdaki gibidir: ");

                foreach (var item in list)
                {
                    Console.WriteLine(item.ad + " " + item.numara + " " + item.departman);
                }

                int arananDeger = 203;

                var BulunanCalisan = LineerArama(list, arananDeger);

                if (BulunanCalisan != null)
                {
                    Console.WriteLine($"Aranan çalışan bulundu: {BulunanCalisan}");
                }

                else
                {
                    Console.WriteLine("Aranan çalışan bulundu.");
                }

                Console.ReadKey();
                
            }
        }

        static Calisan LineerArama(List<Calisan> Calisanlar, int CalisanNumara)
        {
            foreach (var i in Calisanlar)
            {
                if (i.numara == CalisanNumara)
                {
                    return i;
                }
            }
            return null;
        }

        

        

    }
}



