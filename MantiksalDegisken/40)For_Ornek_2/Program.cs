using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_For_Ornek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı ekran üzerinden bir sayı girişi yapacak. Girilen sayının faktöriyel hesabını yapan kodu
            //yazınız.

            Console.WriteLine("Lütfen bir değer giriniz: ");

            int GirilenDeger = Convert.ToInt32(Console.ReadLine());

            int faktoriyel = 1;
            for(int i = 1; i<=GirilenDeger; i++) 
            {
                faktoriyel = i * faktoriyel;
            }
            Console.WriteLine("Girilen değerin faktoriyel sonucu: " + faktoriyel);
            Console.ReadLine();


        }
    }
}
