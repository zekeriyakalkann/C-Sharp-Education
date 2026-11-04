using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_İc_İce_For_Dongusu_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İç içe for döngüsü kullanımı :

            for(int i = 1; i<=20; i++)
            {
                for(int j=1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
