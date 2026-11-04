using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Karar_Yapilari_Alistirma5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kullanıcı kodu:
             * 
             * Kullanıcı Kodu: AA - BB - CC
             *      Admin yetkisine sahipsiniz...
             *
             * Kullanıcı Kodu: DD
             *      Güçlü kullanıcı yetkisine sahipsiniz...
             * Kullanıcı Kodu: FF - EE - GG
             *      Standart kullanıcı yetkisine sahipsiniz...
             * Farklı bir giriş olursa:
             *      Hatalı kullanıcı kodu...
             *
             */

            Console.WriteLine("Merhabalar.");
            Console.WriteLine("Lütfen kullanıcı kodunuzu giriniz: ");

            string KullaniciKod = Console.ReadLine();



            switch (KullaniciKod)
            {
                case "AA":
                    Console.WriteLine("Admin yetkisine sahipsiniz.");
                    break;

                case "BB":
                    Console.WriteLine("Admin yetkisine sahipsiniz.");
                    break;

                case "CC":
                    Console.WriteLine("Admin yetksine sahipsiniz.");
                    break;

                case "DD":
                    Console.WriteLine("Güçlü kullanıcı yetkisine sahipsiniz.");
                    break;

                case "FF":
                    Console.WriteLine("Standart kullanıcı yetkisine sahipsiniz.");
                    break;

                case "GG":
                    Console.WriteLine("Standart kullanıcı yetkisine sahipsiniz.");
                    break;

                case "HH":
                    Console.WriteLine("Standart kullanıcı yetkisine sahipsiniz.");
                    break;

                default:
                    Console.WriteLine("Hatalı kullanıcı kodu girdiniz...");
                    break;

            }

            Console.ReadLine();





        }
    }
}
