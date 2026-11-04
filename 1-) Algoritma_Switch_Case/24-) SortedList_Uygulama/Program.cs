using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24___SortedList_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kitapIcerigi = new SortedList() 
            {
                {1, "Önsöz"},
                {50,"Değişkenler" },
                {40,"Operatörler" },
                {60,"Döngüler" },
                {45,"İlişkisel Operatörler" }
            };

            Console.WriteLine("İçidekiler");
            Console.WriteLine(new string('-',25));
            Console.WriteLine($"{"Konular",-33} {"Sayfalar",8}");
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                Console.WriteLine($"{item.Value,-33} {item.Key,8}");
            }
            Console.ReadKey();
        }
    }
}
