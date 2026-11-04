using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58___Metot_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OgrenciPuanHesapla O1 = new OgrenciPuanHesapla();

            Console.WriteLine("Merhaba. Adınızı ve soyadınızı giriniz: ");

            string adSoyad = Console.ReadLine();

            Console.WriteLine("Lütfen 1. notu giriniz: ");

            decimal not1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. notu giriniz: ");

            decimal not2 = decimal.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Lütfen 3. notu giriniz: ");

            decimal not3 = decimal.Parse(Console.ReadLine());

            O1.OgrenciPuanHesaplama(adSoyad, not1, not2, not3);

            Console.ReadKey();


        }
    }
}
