using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikiTuttuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linear search 5 43 53 36 12
            //int[] dizi = new int[5] { 5, 43, 53, 36, 12 };
            //int ArananDeger = dizi[2];

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    if (dizi[i] == ArananDeger)
            //    {
            //        Console.WriteLine(dizi[i]);
            //    }
            //}
            //Console.ReadKey();


            

            BinarySearch B1 = new BinarySearch();
            int[] siraliDizi = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            Console.WriteLine("Lütfen dizideki hedef elemanı giriniz: ");

            int hedef = Convert.ToInt32(Console.ReadLine());

            int sonuc = B1.İkiliSiralama(siraliDizi, hedef);

            if (sonuc != -1)
            {
                Console.WriteLine($"Aranan {hedef} elemanı, dizinin {sonuc}. index değerindedir.");
            }

            else
            {
                Console.WriteLine($"Aranan {hedef} elemanı dizide bulunamamıştır.");
            }

            Console.ReadKey();
        }
    }
}
