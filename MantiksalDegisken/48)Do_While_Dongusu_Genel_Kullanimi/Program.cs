using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_Do_While_Dongusu_Genel_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Merhaba do while");
            } while (1==2);
            Console.ReadLine();

            //Do while döngüsünün normal while dan farkı şart ne olursa olsun kod mutlaka bir kere çalışır.
        }
    }
}
