using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_SWİTCH_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * switch(ifade)
             * {
             * case kontrol1 :
             * çalışacak olan işlemler...
             * break;
             *  
             * case kontrol2 :
             * çalışacak olan işlemler...
             *  break;
             *default:
             *      çalışacak olan işlemler
             *      break;
             *} 
             * */
            Console.Write("Hangi ay ? ");
            string kullaniciGelen = Console.ReadLine();

            switch(kullaniciGelen)
            {
                case "Ocak":
                case "Nisan":   //Burada case kısmı veya operatörü olarak çalışır. Eğer girilen verilerden bir tanesi doğru ise kod bloğuna girer ve içerisindeki işlemleri sırayla gerçekleştirir.
                    Console.WriteLine("01");
                    break;
                case "Şubak":
                    Console.WriteLine("02");
                    break;
                case "Mart":
                    Console.WriteLine("03");
                    break;
                default: Console.WriteLine("Hatalı bir değer girdiniz...");
                        break;

            }

            Console.ReadLine();
            //Temel kullanımı bu şekildedir...







        }
    }
}
