using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Degiskenler_Alisitirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba.");
            
            Console.Write("İsiminiz nedir ?  ");

            string isim = Console.ReadLine();

            Console.Write("Soyisminiz nedir ?  ");

            string soyisim = Console.ReadLine();

            Console.Write("Yaşadığınız şehir neresidir ?   ");

            string yasanilansehir = Console.ReadLine();

            Console.Clear();        //Bu komut alınan değerleri komple ekrandan temizler. Daha sonra da aşağıdakileri tek tek ekrana yazar.

            Console.WriteLine("İsim : " + isim);

            Console.WriteLine("Soyisim : " + soyisim);

            Console.WriteLine("Yaşadığı Şehir : " +  yasanilansehir);

            Console.ReadLine();




        }
    }
}
