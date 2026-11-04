using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_İc_İce_For_Dongusu_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1'den 10' a kadar olan çarpım tablosunu ekrana yazdırınız.

            /*for (int i = 1; i <= 10; i++)
             {
                 for (int j = 1; j <= 10; j++)
                 {
                     int CarpimSonuc = i * j;
                     Console.WriteLine(i + "x"+ j + "=" + CarpimSonuc);
                 }
             }
             Console.ReadLine();*/


            //2.Yol =

            int CarpimSonuc = 1;

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    CarpimSonuc = i * j;
                    Console.Write("{0}*{1}={2} \t",i,j,CarpimSonuc);    

                }
                Console.WriteLine();
            }
            Console.ReadLine();
            //2. For döngüsü içindeki süslü parantezlerin amacı index olarak değerleri işleme sokmaktır. Yalnız burada indexleri cw içinde tanımlamaız gerekir. Sonucu nereden alacağımızı gösterebilmek için
            //Bu 2. yol çok güzel buna biraz daha dikkat edelim.

        }
    }
}
