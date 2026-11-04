using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Donguler_2
{
    internal class Program
    {
        //Kod satırları yanındaki tornavida ve ampullere dikkat edelim. Çok daha hızlı kod yazmamıza olanak tanıyan komutlar içerebilmektedir. 
        static void Main(string[] args)
        {
            DoWhileOrnek();

            Console.ReadKey();
        }

        private static void DoWhileOrnek()
        {
            Console.WriteLine("Bir değer giriniz: ");
            int n = int.Parse(Console.ReadLine());

            int i = 2;
            do
            {
                Console.Write("{0,-3}", i);

                i += 2; // i = i + 2; olarak yazılan ifademi ampul sayesinde daha dinamik bir hale getirmiş oldum.
            }
            while (i <= n);
        }

        private static void WhileDonguOrnegi()
        {
            int sayac = 1;

            while (sayac <= 10)
            {
                Console.WriteLine(" {0,-3} {1,-3} ", sayac, sayac * sayac); //Bu şekilde yapılır ise sağdan 4 boşluk bırakılır ve 5. değere sayac değeri gelir. -5 Olarak bu değeri alır isek bu sefer de sola yapışık olarak ilk eleman gelir ve boşluklar buna göre hizalanır.
                sayac++;

                //sayac = sayac + 1;
                //sayac += 1;
                //Bu yorum satırı halindeki kullanımlar ile de bu sayacımızı arttırabiliriz.

            }
        }
    }
}
