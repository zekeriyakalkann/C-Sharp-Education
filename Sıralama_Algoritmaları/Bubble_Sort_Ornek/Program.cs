using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            
            int gecici;
            int[] BubbleSort = new int[6];
            Random Rnd = new Random();
            for (int i = 0; i < BubbleSort.Length; i++)
            {
                int RandomDeger = Rnd.Next(1, 10);
                BubbleSort[i] = RandomDeger;
            }
            Console.WriteLine("Dizimiz: ");
            DiziYazdir(BubbleSort);
            for (int i = 0; i < BubbleSort.Length - 1; i++)
            {
                for (int j = 1;  j < BubbleSort.Length; j++)
                {
                    if (BubbleSort[j-1]> BubbleSort[j])
                    {
                        gecici = BubbleSort[j-1];
                        BubbleSort[j-1] = BubbleSort[j];
                        BubbleSort[j] = gecici;
                    }
                }
                DiziYazdir(BubbleSort);
            }
            Console.WriteLine("Dizimizin sıralı hali: ");
            DiziYazdir(BubbleSort);
            Console.ReadKey();
        }

        public static void DiziYazdir(int[] BubbleSort)
        {
            for (int i = 0; i < BubbleSort.Length; i++)
            {
                Console.Write(BubbleSort[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++");
        }

    }
}