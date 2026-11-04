using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_IF_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If karar yapısı = Eğer anlamına gelir ve şart doğru ise süslü parantezlere girer ve kodları çalıştırır.
            Console.Write("1. Değeri giriniz:  ");
            decimal deger1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("2. Değeri giriniz:  ");
            decimal deger2 = Convert.ToDecimal(Console.ReadLine());

            decimal toplam = deger1 + deger2;

            bool Kontrolet = toplam > 50;
            if (Kontrolet)
            {
                Console.WriteLine("Değerlerin toplamı 50'den büyüktür...");
            }
            Console.ReadLine();
            //Temel olarak bu şekilde kullanılmaktadır...

        }
    }
}
