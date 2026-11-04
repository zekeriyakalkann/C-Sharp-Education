using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Burası parametresiz - geriye değer döndürmeyen metotlardır.
            //SelamVer();   //Burada metotların amacı aslında belli olmaktadır. Belki de yüzlerce satırlık kodları tekrar tekrar kullanacaktık. 
            //SelamVer();   //işte burada metotlar sayesinde tek satırda işi bitirebilmekteyiz. Bu yüzden metotlar ciddi ölçüde önem taşımaktadır.
            //SelamVer();
            //SelamVer();
            //SelamVer();
            //SelamVer();
            //SelamVer();
            //SelamVer();
            //SelamVer();
            //AdiniYazdir();
            //Metotlar uygulama 1 bitti. 

            //++++++++++++++++

            //Parametre alan - geriye değer döndürmeyen metot yazma: 

            //ToplamaYap(5, 7);    //Burada parametre değerlerini vermemiz gerekmektedir yoksa kodda hata meydana gelmektedir. 
            //carpmayap(5, 8, 4);
            //Console.ReadLine();
            //Metotlar uygulama 2 bitti. 

            //++++++++++++++++++

            //Parametre alan - geriye değer döndüren metotlar : 
            //Return anahtar kelimesi 
            //Metot sonu. 

            //int Donendeger = toplamayap(6, 7);

            //if (Donendeger > 10)
            //{
            //    Console.WriteLine("Yapılan işlem sonucu 10 dan büyüktür.");
            //}
            //else if (Donendeger == 10)
            //{
            //    Console.WriteLine("Yapılan işlem sonucu 10 a eşittir.");
            //}
            //else
            //{
            //    Console.WriteLine("Yapılan işlem sonucu 10 dan küçüktür.");
            //}
            //Console.ReadLine();
            //Metotlar uygulama 3 bitti. 

            //+++++++++++++++++++++++++++

            //Console.Write("Bir değer giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //girilensayi(sayi);
            //Console.ReadLine();
            //Metotlar uygulama 4 bitti. 

            //++++++++++++++++++++++++++

            //

        //}

        //static void SelamVer() 
        //{
        //    Console.WriteLine("Selamlar :)");
        //    //Buradaki Console.readline ı sildik.Çünkü kodun ilerlemesini buradaki console.readline engellemektedir. 
        //}

        //static void AdiniYazdir()
        //{
        //    Console.WriteLine("Gamze");
        //    Console.ReadLine();

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //static void ToplamaYap(int sayi1 , int sayi2)
        //{
        //    Console.WriteLine("Bu iki sayının toplamı : " + (sayi1+sayi2));
        //}

        //static void carpmayap(int sayi1, int sayi2, int sayi3)
        //{
        //    Console.WriteLine("Bu 3 sayının çarpımı : " + (sayi1 * sayi2 * sayi3));
        //}

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        //static int toplamayap(int sayi1, int sayi2)
        //{
        //    int sonuc = sayi1 + sayi2;
        //    return sonuc;
        //}

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //Kullanıcıdan girilen sayının tek mi çift mi olduğunu anlatan metodu yaz.

        //static void girilensayi(int sayi)
        //{
        //    if (sayi%2==0) 
        //    {
        //        Console.WriteLine("Sayı çifttir.");
        //    }
        //    else 
        //    {
        //        Console.WriteLine("Sayı tektir.");
        //    }



    

        }

    }
}
