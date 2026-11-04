using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27___Stack_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack uygulama 

            Console.WriteLine("Lütfen bir sayı girişi yapınız: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();

            while (sayi > 0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;   //Burada sayının değeri sıfıra eşitlemesi olayı bölümden sonra kalanı almamasından kaynaklanmaktadır.
            }

            int i = 0;
            int n = sayiYigini.Count - 1;
            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"\t{s,7} x " +
                    $"{Math.Pow(10,n-i),7}\t = " +
                    $"{s*Math.Pow(10,n-i),7}");
                i++;
            }
            Console.ReadKey();
        }
    }
}
