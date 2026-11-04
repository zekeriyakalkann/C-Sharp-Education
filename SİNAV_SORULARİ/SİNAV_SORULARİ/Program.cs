using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SİNAV_SORULARİ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilecek rastgele 10 sayıyı diziye attıktan sonra en küçük ve en büyük sayıyı ekrana 
            //yazdıran C# kodunu yazınız.

            //int[] dizi = new int[10];

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.Write("Dizinin {0}. elemanını girin: ", i + 1);
            //    dizi[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.Write("Dizi= ");
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.Write(dizi[i] + " ");
            //}
            //Console.WriteLine();

            //int enbuyuk = dizi[0];
            //int enkucuk = dizi[0];

            //for (int i = 1; i < dizi.Length; i++)
            //{
            //    if (dizi[i] > enbuyuk)
            //    {
            //        enbuyuk = dizi[i];
            //    }
            //    if (dizi[i] < enkucuk)
            //    {
            //        enkucuk = dizi[i];
            //    }
            //}

            //Console.WriteLine("En küçük eleman {0} ve En büyük eleman {1}", enkucuk, enbuyuk);
            //Console.ReadLine();

            //Klavyeden girilecek rastgele 10 sayıyı diziye attıktan sonra en küçük ve en büyük sayıyı ekrana 
            //yazdıran C# kodunu yazınız.

            //int[] dizi = new int[10];

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine("Dizinin {0}. elemanını giriniz: ", i + 1);
            //    dizi[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int max = dizi[0];
            //int min = dizi[0];
            //Console.Write("Dizi elemanları: ");

            //foreach (int i in dizi)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (dizi[i] > max)
            //        max = dizi[i];
            //    else if (dizi[i] < min)
            //        min = dizi[i];
            //}
            //Console.WriteLine("Dizinin en büyük elemanı: " + max);
            //Console.WriteLine("Dizinin en küçük elemanı: " + min);
            //Console.ReadKey();

            //Klavyeden girilen bir sayının 6 basamaklı olup olmadığını kontrol edip cevabı ekrana yazdırınız.
            //Sonrasında eğer sayı 6 basamaklı ise sayının rakamlarından tek olanları bulup bir diziye koyunuz.
            //En son olarak bu diziye koyulan tek basamaklı sayıların ortalamasını bulup ekrana yazınız.

            Console.WriteLine("Bir sayı giriniz: ");
            string sayistring = Console.ReadLine();
            int sayi;

            if (sayistring.Length != 6)
            {
                Console.WriteLine("Girilen sayı 6 basamaklı değil.");
            }
            if (sayistring.Length == 6)
            {
                Console.WriteLine("Girilen sayı 6 basamaklı");
                sayi = int.Parse(sayistring);
                int basamak = 0;
                List<int> teksayilar = new List<int>();
                for (int i = 0; i < sayistring.Length; i++)
                {
                    basamak = sayi % 10;
                    sayi = sayi / 10;
                    if (basamak % 2 != 0)
                    {
                        teksayilar.Add(basamak);
                    }
                }
                Console.Write("6 basamaklı sayının tek basamakları= ");
                for (int i = 0; i < teksayilar.Count; i++)
                {
                    Console.Write(teksayilar[i] + " ");
                }
                int toplam = 0;
                for (int i = 0; i < teksayilar.Count; i++)
                {
                    toplam += teksayilar[i];
                }
                Console.WriteLine();
                Console.WriteLine("Tek olanların ortalaması= " + toplam / teksayilar.Count);
            }

            Console.ReadKey();





        }
    }
}
