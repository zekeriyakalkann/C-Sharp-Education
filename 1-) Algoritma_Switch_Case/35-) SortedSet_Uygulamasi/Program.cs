using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35___SortedSet_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sayilar = new List<int>();
            var r = new Random();

            Console.WriteLine();
            for (int i = 0; i < 1000; i++)
            {
                sayilar.Add(r.Next(0,50));
                Console.Write($"{sayilar[i],-3}");
            }
            Console.WriteLine();

            //Listedeki benzersiz elemanları bulma
            var benzersizSayiListesi = 
                new SortedSet<int>(sayilar);
            Console.WriteLine();
            Console.WriteLine("Benzersiz sayı listemiz:\n");

            foreach (int sayi  in benzersizSayiListesi)
            {
                Console.Write($"{sayi,-3}");
            }
            Console.WriteLine();
            Console.WriteLine("\nBenzersiz {0} sayı vardır ",benzersizSayiListesi.Count);


            Console.ReadKey();

        }
    }
}
