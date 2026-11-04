using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Bolum_Sonu_Alistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Merhaba
             * İsminiz : Zekeriya
             * Soyisminiz : Kalkan
             * Şehir : Mersin
             * Yaş : 21
             * 
             * Ekranı Öncesinde Temizle
             * 
             * 
             */


            Console.WriteLine("Merhaba.");
            
            Console.Write("İsminiz: ");
            
            string isim = Console.ReadLine();

            Console.Write("Soyisminiz: ");

            string soyisim = Console.ReadLine();

            Console.Write("Yaşadığınız şehir: ");

            string yasanilansehir = Console.ReadLine();

            Console.Write("Yaşınız: ");

            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Clear();


            Console.WriteLine("İsminiz: " + isim);
            Console.WriteLine("Soyisminiz: " + soyisim);
            Console.WriteLine("Yaşadığınız Şehir: " + yasanilansehir);
            Console.WriteLine("Yaşınız: " + yas);

            Console.ReadLine();




        }
    }
}
