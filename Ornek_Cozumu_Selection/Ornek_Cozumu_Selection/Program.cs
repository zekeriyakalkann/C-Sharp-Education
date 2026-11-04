using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Cozumu_Selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İlk olarak dizimizi oluşturuyoruz: 
            int[] dizi = { 64, 25, 12, 22, 11 };

            Console.WriteLine("Dizimizin ilk hali: ");
            DiziYazdir(dizi);

            //Selection algoritması yardımı ile dizinin sıralanmış biçimi: 
            SelectionSiralama(dizi);

            Console.WriteLine("\nDizimizin sıralanmış hali: ");
            DiziYazdir(dizi);
            Console.ReadKey();


        }

        public static void SelectionSiralama(int[] dizi)
        {
            int minIndex;

            for (int i = 0; i < dizi.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < dizi.Length; j++)
                {
                    if (dizi[j] < dizi[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int change = dizi[minIndex];
                dizi[minIndex] = dizi[i];
                dizi[i] = change;
            }


        }
        public static void DiziYazdir(int[] dizi)
        {
            foreach (int d in dizi)
            {
                Console.Write(d + " ");
            }
        }




    }
}
