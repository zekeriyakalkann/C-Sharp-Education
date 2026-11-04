using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57___Metot_Ornek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik M = new Matematik();
            YenidenIslemYap:
            M.Menu();

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            int Islem = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 1. sayı değerini giriniz: ");

            decimal kullaniciSayi1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayı değerini giriniz: ");

            decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;
            switch (Islem)
            {
                case 1: //Toplama
                    sonuc = M.toplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                    break;

                case 2: //Çıkarma
                    sonuc = M.cikarmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    break;

                case 3:// Çarpma
                    sonuc = M.carpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    break;

                case 4: //Bölme
                    sonuc = M.bolmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    break;

                default:
                    Console.WriteLine("Belirtmiş olduğunuz değer liste içeirisinde bulunamadı.");
                    Console.WriteLine("Lütfen tekrar deneyiniz");
                    System.Threading.Thread.Sleep(2000);    //Hemen sistemde bizi başa atmıyor 2 saniye kadar bekletiyor. Bu metot da buna yaramaktadır. 
                    goto YenidenIslemYap;
            }

            Console.WriteLine("Yeniden işlem yapmak istiyor musunuz ? [E/H]");
            string EH = Console.ReadLine();
            if (EH == "E")
            {
                goto YenidenIslemYap;
            }

        }
    }
}
