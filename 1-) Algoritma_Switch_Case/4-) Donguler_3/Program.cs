using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Donguler_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = length - 1; i >= 0; i--) forr yazıp taba bastığımızda for döngüsü içerisindeki ifadeyi ters çevirir.

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0) //Bu komutla ekranda 3 ve 3 ün katlarını görmemeyi hedeflemekteyiz.
                    continue;
                Console.WriteLine("{0,-3}", i);
            }

            Console.ReadLine();
        }
    }
}
