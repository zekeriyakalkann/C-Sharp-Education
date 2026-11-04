using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Do_While_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıyı do while döngüsüne alın. Kullanıcı adı = Demo, Şifre = Demo olsun.
            //Kullanıcı değeri doğru girene kadar giriş yapmaya devam etsin. Doğru girerse de ekrana 
            //tebrikler. Doğru giriş yaptınız şeklinde ekrana yazdırsın.

            Console.WriteLine("Lütfen kullanıcı adınızı ve şifrenizi giriniz: ");
            string KullaniciAdi = string.Empty;
            string sifre = string.Empty;
            int sayac = 0;
            do
            {
                if (sayac>0)
                {
                    Console.WriteLine("Hatalı kullanıcı adı veya şifre. Lütfen tekrar deneyiniz: ");
                }

                Console.WriteLine("Kullanıcı adı: ");
                KullaniciAdi = Console.ReadLine();

                Console.WriteLine("Şifre:");
                sifre = Console.ReadLine();
                sayac++;

            } while (KullaniciAdi.ToLower() != "demo" || sifre.ToLower() !="demo");
            //Burada to.lower kullanmamızın sebebi Klavyeden girilen varyasonlar Demo, DeMo vs. Şeklinde gelebileceği içindir.

            Console.WriteLine("Tebrikler. Başarılı bir şekilde giriş yaptınız...");
            Console.ReadLine();

        }
    }
}
