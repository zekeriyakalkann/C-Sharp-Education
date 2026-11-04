using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Karar_Yapilari_Alistirma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi lütfen seçiniz: ");
            Console.WriteLine("1-) Toplama");
            Console.WriteLine("2-) Çıkarma");
            Console.WriteLine("3-) Çarpma");
            Console.WriteLine("4-) Bölme");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Toplama işlemini seçtiniz. Lütfen 2 adet değer giriniz: ");

                    Console.WriteLine("1.değer: ");
                    double sayi1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("2.değer: ");
                    double sayi2 = Convert.ToDouble(Console.ReadLine());

                    double toplama = sayi1 + sayi2;
                    Console.WriteLine("Sonucunuz: " + toplama);
                    break;
                case "2":
                    Console.WriteLine("Çıkarma işlemini seçtiniz. Lütfen 2 adet değer giriniz:");

                    Console.WriteLine("1.değer: ");
                    double sayi3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("2.değer: ");
                    double sayi4 = Convert.ToDouble(Console.ReadLine());

                    double cikarma = sayi3 - sayi4;
                    Console.WriteLine("Sonucunuz: " + cikarma);
                    break;
                case "3":
                    Console.WriteLine("Çarpma işlemini seçtiniz. Lütfen 2 adet değer giriniz:");

                    Console.WriteLine("1.değer: ");
                    double sayi5 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("2.değer: ");
                    double sayi6 = Convert.ToDouble(Console.ReadLine());

                    double carpma = sayi5 * sayi6;
                    Console.WriteLine("Sonucunuz: " + carpma);
                    break;
                case "4":
                    Console.WriteLine("Bölme işlemini seçtiniz. Lütfen 2 adet değer giriniz:");

                    Console.WriteLine("1.değer: ");
                    double sayi7 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("2.değer: ");
                    double sayi8 = Convert.ToDouble(Console.ReadLine());


                    if (sayi8 == 0)
                    {
                        Console.WriteLine("Böyle bir kullanım olamaz. Sonuc tanımsız gelir...");
                    }
                    else
                    {
                        double bolme = sayi7 / sayi8;
                        Console.WriteLine("Sonucunuz:" + bolme);

                    }

                    break;


                default:
                    Console.WriteLine("Hatalı tuşlama yaptınız...");
                    break;

            }
            Console.ReadLine();



        }
    }
}
