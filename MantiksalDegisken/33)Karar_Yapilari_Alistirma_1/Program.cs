using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Karar_Yapilari_Alistirma_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı adı : Zekeriya
            //Sifre : 123

            
            Console.Write("Kullanıcı adınızı giriniz: ");
            string kullaniciAdi = Console.ReadLine();
            
            Console.Write("Şifrenizi giriniz: ");
            string Sifre = Console.ReadLine();

            if (kullaniciAdi == "Zekeriya" && Sifre == "123")
            {
                Console.WriteLine("Merhaba.");
                Console.WriteLine("Başarılı bir şekilde giriş yaptınız.");
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
                Console.WriteLine("Kullanıcı adınızı ve şifrenizi lütfen tekrar kontrol ediniz...");
            }

            Console.ReadLine();




            
        }
    }
}
