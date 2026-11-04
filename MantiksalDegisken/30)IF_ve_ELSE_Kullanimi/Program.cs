using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_IF_ve_ELSE_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //else: if karar yapısının yanlış olması durumunda devreye giren karar yapısıdır.

            Console.Write("1. Değeri giriniz: ");
            decimal deger1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("2. Değeri giriniz: ");
            decimal deger2 = Convert.ToDecimal(Console.ReadLine());

            decimal toplam = deger1 + deger2;

            if (toplam>50)
            {
                Console.WriteLine("Değerler toplamı 50'den büyüktür...");
            }
            else
            {
                Console.WriteLine("Değerler toplamı 50'den küçüktür...");
            }
            Console.ReadLine();
            //Temel kullanımı bu şekildedir...
        }
    }
}
