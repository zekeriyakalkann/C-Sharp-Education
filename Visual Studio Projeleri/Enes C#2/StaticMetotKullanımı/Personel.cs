using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetotKullanımı
{
     class Personel
    {
        public static void isimsoyisim()
        {
            Console.WriteLine("Gamze Mastarcıoğlu");
        }
        public static void sayitopla(int sayi1, int sayi2)
        {
            Console.WriteLine("İki sayının toplamı :" + (sayi1 + sayi2));
        }
    }
}
