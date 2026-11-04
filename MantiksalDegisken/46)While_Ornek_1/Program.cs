using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_While_Ornek_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan gelen değeri 1 eksilterek 0 a ulaşıncaya kadar ekrana yazdıralım.

            /*Console.WriteLine("Lütfen bir değer giriniz: ");
            int KullaniciGirisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilen değerin 0'a kadar yazılışı:");

            while (KullaniciGirisi >= 0)
            {

                Console.WriteLine(KullaniciGirisi);
                KullaniciGirisi--;

            }*/

            //Kullanıcıdan gelen değerlerin toplamını ekrana yazdıralım. 0'dan küçük bir değer girildiğinde 
            // toplama işlemini bitirelim ve ekrana toplam sonucunu yazdıralım.

            int DegerToplam = 0;
            Console.WriteLine("Lütfen toplamak istediğiniz sayıları giriniz: ");
            Console.WriteLine("Not: \" - \" değerleri girdiğinizde sistem toplamayı sonlandıracaktır.");

            while (true)
            {
                int GirilenDeger = Convert.ToInt32(Console.ReadLine());

                if (GirilenDeger <= -1)
                {
                    break;
                }
                else
                {
                    DegerToplam = DegerToplam + GirilenDeger;
                }


            }
            Console.WriteLine("Girilen değerlerin toplamı: {0}", DegerToplam);
            Console.ReadLine();


        }
    }
}
