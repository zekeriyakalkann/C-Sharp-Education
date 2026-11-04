using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_For_Dongusu_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrana 1 den 10 a kadar olan değerleri yazdıralım.

            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            //Ekrana 0 den 100 e kadar olan çift sayıları yazdıralım.

            for (int j = 0; j <= 100; j +=2)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("");

            //0 ve 100 arasındaki çift sayıların toplamı nedir ? 

            int toplam = 0;

            for(int k=0; k<=100; k += 2)
            {
                toplam = toplam + k;
                
            }
            Console.WriteLine("0'dan 100'e kadar olan sayıların toplamı: "+ toplam);
            Console.ReadLine();


        }
    }
}
