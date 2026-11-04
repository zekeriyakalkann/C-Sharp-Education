using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    
    internal class Program
    {
        static void BubbleSort(int[] dizi)
        {
            int n = dizi.Length;

            for (int i = 0; i < n-1; i++) 
            {
                for (int j = 0; j < n - i- 1; j++) 
                {
                    if (dizi[j] > dizi[j+1])
                    {
                        int gecici = dizi[j];
                        dizi[j] =dizi[j+1];
                        dizi[j+1] =gecici;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] dizi = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Sıralanmamış dizi: ");
            Yazdir(dizi);

            BubbleSort(dizi);

            Console.WriteLine("Dizimizin sıralanmış hali: ");

            Yazdir(dizi);
            Console.ReadKey();
        }

        static void Yazdir(int[] dizi)
        {
            foreach (var d in dizi)
            {
                Console.Write(d + " ");
            }
        }
    }
        
    
}
