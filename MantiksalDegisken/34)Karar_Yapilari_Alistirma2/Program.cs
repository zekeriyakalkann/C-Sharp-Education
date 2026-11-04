using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Karar_Yapilari_Alistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sistem içerisine giriş yapabilecek kullanıcı kodları:
             * 
             * ABC - 123 - 236 - CMK
             * Kullanıcı girişiniz başarılı.
             * 
             * Sistem içerisine girmesi yasaklanmış kullanıcı kodları:
             * 
             * HHH - MMM - BBB 
             * Kullanıcı girişiniz kilitlenmiştir..
             * 
             * Bunlar dışında ise:
             * 
             * Hatalı kullanıcı kodu girdiniz. Lütfen tekrar deneyiniz...
             * 
             * 
             * 
             * 
             * 
             * */


            Console.WriteLine("Merhaba.");
            Console.WriteLine("Lütfen giriş kodunuzu tuşlayınız:");
            string girisKod = Console.ReadLine();

            if (girisKod == "ABC" || girisKod == "123" || girisKod == "236" || girisKod == "CMK")
            {
                Console.WriteLine("Tebrikler. Başarılı bir şekilde sisteme giriş yaptınız...");
            }
            else if (girisKod =="HHH" ||  girisKod =="MMM" || girisKod == "BBB")
            {
                Console.WriteLine("Yasaklı kullanıcı kodu. Sisteme girişiniz kilitlenmiştir...");
            }
            else
            {
                Console.WriteLine("Hatalı bir kod girdiniz. Tekrar deneyiniz: ");
            }
            Console.ReadLine();












        }
    }
}
