using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Karar_Yapilari_Alistirma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Not ortalaması sistemine hoşgeldiniz...");
            Console.WriteLine("Lütfen önce adınızı giriniz: ");
            string isim = Console.ReadLine();

            Console.WriteLine("1.Notunuzu giriniz: ");
            double not1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2.Notunuzu giriniz: ");
            double not2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3.Notunuzu giriniz: " );
            double not3 = Convert.ToDouble(Console.ReadLine());

            double ortalama = (not1 + not2 + not3)/3;

            if (ortalama<45)
            {
                Console.WriteLine("Kaldınız...");
            }
            else if (ortalama >=45 && ortalama <70)
            {
                Console.WriteLine("Dersi orta ile geçtiniz...");
            }
            else if (ortalama>=70 && ortalama<90)
            {
                Console.WriteLine("Dersi iyi ile geçtiniz...");
            }
            else if (ortalama >=90 && ortalama <=100)
            {
                Console.WriteLine("Dersi pek iyi ile geçtiniz...");
            }
            else
            {
                Console.WriteLine("Geçersiz notlar girdiniz. Lütfen notları tekrar giriniz: ");
            }
            Console.ReadLine();








        }
    }
}
