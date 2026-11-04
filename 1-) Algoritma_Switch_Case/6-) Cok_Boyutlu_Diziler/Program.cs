using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _6___Cok_Boyutlu_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[,] matris = new double[,]
            {   { 1, 2, 3 },
                { 2, 3, 4 },
                { 3, 4, 5 }
            };
            //Yukarıdaki gibi bir tanımlama çok boyutlu bir dizi tanımlamasıdır. 
            //Tek virgül dizinin bize çok boyutlu olduğunu söylemek için yeterli ve aşağıdaki kodu değiştirmeden yukarıdaki
            //matris dizimizi güncellesek dahi aynı kodlar aynı mantık ile çalışmaya devam edecektir.

            double toplam = 0;
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        matris[i, j] = -1;
                    }

                    if(i%2 == 0 && j%2 == 0)
                    {
                        matris[i, j] = 0;
                    }

                    toplam += matris[i, j];
                    Console.Write($"{matris[i, j],-3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Toplam: {toplam}");


            Console.ReadKey();
        }

        private static void DiziOrnek()
        {
            Console.WriteLine("Lütfen yapacak olduğunuz dizinin boyutunun girişini yapınız: ");

            int boyut = int.Parse(Console.ReadLine());
            int[] sayilar = new int[boyut];
            Random r = new Random();

            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = r.Next(1, 10);

            foreach (var i in sayilar)
            {
                //Console.WriteLine(sayilar[i]); Böyle bir yazım yanlıştır. Çünkü buradaki i sayilar dizisi içerisindeki elemanları direkt olarak temsil etmektedir.
                Console.WriteLine($"{i,-3} {i * i,-3}");
            }
        }
    }
}
