using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57__Metot_Uygulama_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik M1 = new Matematik();
            YenidenIslemYap:
            M1.Menu();

            int kullaniciSecim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 1. sayı değerini giriniz: ");

            decimal kullaniciSayi1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayı değerini giriniz: ");

            decimal kullaniciSayi2 = Convert.ToDecimal(Console.ReadLine());

            decimal sonuc = 0;

            switch (kullaniciSecim)
            {
                case 1: //Toplama
                    Console.WriteLine("Toplama işlemini seçtiniz.");
                    sonuc = M1.Toplama(kullaniciSayi1, kullaniciSayi2);
                    Console.WriteLine("Sonucunuz: " + sonuc);
                    break;

                case 2: //Çıkarma
                    Console.WriteLine("Çıkarma işlemini seçtiniz.");
                    sonuc = M1.Cikarma(kullaniciSayi1, kullaniciSayi2);
                    Console.WriteLine("Sonucunuz: " + sonuc);
                    break;

                case 3: //Çarpma
                    Console.WriteLine("Çarpma işlemini seçtiniz.");
                    sonuc = M1.Carpma(kullaniciSayi1, kullaniciSayi2);
                    Console.WriteLine("Sonucunuz: " + sonuc);
                    break;

                case 4: //Bölme
                    Console.WriteLine("Bölme işlemini seçtiniz.");
                    sonuc = M1.Bolme(kullaniciSayi1, kullaniciSayi2);
                    Console.WriteLine("Sonucunuz: " + sonuc);
                    break;

                default:
                    Console.WriteLine("Belirmiş olduğunuz değer liste içerisinde bulunamadı.");
                    Console.WriteLine("Lütfen tekrar deneyiniz.");
                    System.Threading.Thread.Sleep(3000);
                    goto YenidenIslemYap;
            }
            Console.WriteLine("Yeniden işlem yapmak istiyor musunuz? ");
            string EH = Console.ReadLine();

            if (EH == "E")
            {
                goto YenidenIslemYap;
            }
        }
    }
}
