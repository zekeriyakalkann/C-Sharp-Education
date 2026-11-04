using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SİNAV_SORULARİ_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir dizide rastgele sayılar vardır ve bu dizide aynı sayıdan birden fazla vardır.
            //İçindeki aynı sayıları farklı bir dizide toplayan ve yazdıran C# kodunu yazınız.

            //Console.WriteLine("Dizi kaç elemanlı olsun? ");
            //int elemansayisi = Convert.ToInt32(Console.ReadLine());
            //int[] dizi = new int[elemansayisi];
            //Random rnd = new Random();
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = rnd.Next(1, 5);
            //}

            //Console.Write("Dizinin ilk hali: ");
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.Write(dizi[i] + " ");
            //}

            //Console.WriteLine();
            //List<int> yenidizi = new List<int>();

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    int sayac = 0;

            //    for (int j = 0; j < dizi.Length; j++)
            //    {
            //        if (i != j && dizi[i] == dizi[j])
            //        {
            //            sayac++;
            //            break;
            //        }
            //    }

            //    if (sayac > 0)
            //    {
            //        yenidizi.Add(dizi[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.Write("Birden fazla olan sayılar: ");
            //for (int i = 0; i < yenidizi.Count; i++)
            //{
            //    Console.Write(yenidizi[i] + " ");
            //}

            //Console.ReadLine();

            //Bir dizide rastgele sayılar vardır ve bu dizide aynı sayıdan birden fazla vardır.
            //İçindeki aynı sayıları farklı bir dizide toplayan ve yazdıran C# kodunu yazınız.

            //Console.WriteLine("Lütfen dizinin kaç elemanlı olacağını seçiniz: ");
            //int diziUzunluk = int.Parse(Console.ReadLine());
            //int[] dizi = new int[diziUzunluk];
            //Random rnd = new Random();

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = rnd.Next(1, 5);
            //}
            //Console.WriteLine("Dizinin ilk oluşmuş hali: ");
            //foreach (int diziElemanlari in dizi)
            //{
            //    Console.Write(diziElemanlari + " ");
            //}
            //Console.WriteLine();

            //List<int> yeniDizi = new List<int>();

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    int sayac = 0;
            //    for (int j = 0; j < dizi.Length; j++)
            //    {
            //        if (i != j && dizi[i] == dizi[j])
            //        {
            //            sayac++;
            //            break;
            //        }
            //    }
            //    if (sayac > 0)
            //    {
            //        yeniDizi.Add(dizi[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Dizideki tekrar eden elemanlar: ");

            //foreach (int i in yeniDizi)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.ReadKey();

            //Bir dizide rastgele sayılar vardır ve bu dizide aynı sayıdan birden fazla vardır.
            //İçindeki aynı sayıları farklı bir dizide toplayan ve yazdıran C# kodunu yazınız.

            Console.WriteLine("Lütfen dizinizin eleman sayısını giriniz: ");
            int diziuzunluk = int.Parse(Console.ReadLine());
            int[] dizi = new int[diziuzunluk];
            Random rnd = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1,5);
            }
            Console.WriteLine("Dizinin ilk hali: ");

            foreach (int i in dizi)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Yeni bir dizi oluşturacağız. Tekrar eden elemanları daha kolay bir dizi içerisine atmak için List kullanmak
            //mantıklı olacaktır...

            List<int> yenidizi = new List<int>();

            for (int i = 0;i < dizi.Length; i++)
            {
                int sayac = 0;
                for (int j = 0;j < dizi.Length;j++) 
                {
                    if (dizi[i] == dizi[j] && i != j)
                    {
                        sayac++;
                        break;
                    }
                    
                }
                if (sayac > 0)
                {
                    yenidizi.Add(dizi[i]);
                }
            }
            Console.WriteLine("Dizideki tekrar eden elemanlar: ");
            foreach (int i in yenidizi)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
