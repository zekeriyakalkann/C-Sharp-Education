using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlTypes;

namespace Ornekler_ve_Cozumler_2
{

    internal class Program
    {
        static void Main(string[] args)
        {

            //while (true)  //Şart döngü içinde false olana kadar devam eder ya da break ile kırılana kadar devam eder.
            //{

            //}

            //Ekrana 1 den 10 a kadar olan değerleri yazdıralım.

            /*int i = 1;
            while (i <=10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();*/

            //Örnek 1 : Kullanıcıdan gelen değeri 0 a ulaşıncaya kadar ekrana yazdıralım.

            //Console.Write("Lütfen bir değer giriniz: ");
            //int kullaniciGiris = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sayının 0'a kadar olan şekli: ");
            //while (kullaniciGiris>=0)
            //{
            //    Console.WriteLine(kullaniciGiris);
            //    kullaniciGiris--;
            //}
            //Console.ReadKey();

            //Kullanıcıdan gelen değerlerin toplamını ekrana yazdıran 0 dan küçük bir değer girişi yapılırsa 
            // toplama işlemini bitirelim ve toplam sonucunu yazdıralım: 
            //Console.WriteLine("Lütfen toplamak istediğiniz değerleri giriniz: ");
            //Console.WriteLine("\"-\" li değerler işleme dahil edilmeyecektir ve işlem sonlanıp cevap yazılacaktır.");
            //int sayac = 1;
            //int degertoplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("{0}. değeri giriniz: ",sayac);
            //    sayac++;
            //    int kullanicideger = int.Parse(Console.ReadLine());
            //    if (kullanicideger<0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        degertoplam = degertoplam + kullanicideger;
            //    }
            //}

            //Console.WriteLine("İşleminizin sonucu: " + degertoplam);
            //Console.ReadKey();

            //Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının tahmin etmesini
            //isteyecek bir uygulama yazalım. 

            //Random rnd = new Random();
            //int sistemdeger = rnd.Next(1, 10);
            //int sayac = 0;
            //Console.WriteLine("Lütfen değeri tahmin etmeye çalışınız: ");
            //while (true)
            //{
            //    string kullanicigiris = Console.ReadLine();
            //    if(int.Parse(kullanicigiris) == sistemdeger)
            //    {
            //        Console.WriteLine("Tebrikler değeri doğru tahmin ettiniz. Değer: " + sistemdeger);
            //        break;
            //    }
            //    else
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine("{0}. denemede doğru tahmin yaptınız.",sayac);
            //Console.ReadKey();


        }

    }
}

