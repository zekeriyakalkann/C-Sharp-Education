using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_OPERATORLER_Alistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı adı = Zekeriya
            //Şifre : 123

            Console.Write("Kullanıcı adınızı lütfen giriniz:  ");
            string KullaniciAdi = Console.ReadLine();

            Console.Write("Şifrenizi lütfen giriniz:  ");
            string sifre = Console.ReadLine();

            bool Kontrol1 = KullaniciAdi == "Zekeriya";
            bool Kontrol2 = KullaniciAdi != "Zekeriya";

            bool Kontrol3 = sifre == "123";
            bool Kontorl4 = sifre != "123";

            //Bu şekildedir...



        }
    }
}
