using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yildizlarla_Soru_Cozumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*
            //**
            //***
            //****
            //*****
            //******
            //*******

            //Bu yapıda bir örnek yapalım.

            //Console.WriteLine("Lütfen üçgenin boyutunun girişini yapınız: ");

            //int boyut = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < boyut; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.ReadKey();

            //1. Örnek başarıyla tamamlandı.

            //Dört kenarı olan bir geometrik şekil çizelim

            //Console.WriteLine("Lütfen dörtgenin en uzunluğunu giriniz: ");
            //int en = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen dörtgenin boy uzunluğunu giriniz: ");
            //int boy = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < boy; i++)
            //{
            //    for (int j = 0; j < en; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            //Console.ReadKey();

            //2. Örnek başarıyla tamamlandı.

            //Yıldızlarla bir piramit şekli çizelim.

            //Console.WriteLine("Lütfen piramitin boyutunu giriniz: ");

            //int boyut = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < boyut; i++)
            //{
            //    for (int j = 0; j < boyut - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 0; k <= i; k++)
            //    {
            //        Console.Write("*");
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("");
            //}

            //Console.ReadKey();

            //3. Örnek başarıyla tamamlandı.

            // Şimdi de ortası boş bir dörtgen çizmeye çalışalım.

            //Console.WriteLine("Lütfen dörtgenin eninin giriniz: ");
            //int en = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen dörtgenin boyunu giriniz: ");
            //int boy = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < boy; i++)
            //{
            //    if (i == 0 || i == boy-1)
            //    {
            //        for (int j = 0; j < en; j++)
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    else
            //    {
            //        Console.Write("*");
            //        for (int k = 0; k < boy-2; k++)
            //        {
            //            Console.Write(" ");
            //        }
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine("");
            //}

            //Console.ReadKey();

            //4. Örnek başarıyla tamamlandı.

            //Yıldızlarla baklava dilimi yapalım.

            Console.WriteLine("Lütfen baklava diliminin boyutunu giriniz: ");
            int boyut = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= boyut; i++)
            {
                for (int j = boyut; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }

            for (int i = (boyut-1); i >=1; i--)
            {
                for (int j = boyut; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
