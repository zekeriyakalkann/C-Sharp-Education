using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Tur_Donusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bilinçli tür dönüşümü dediğimiz şey genelde sayılarda olmaktadır. Şimdi bunu görmek için örnek çözeceğiz...

            byte sayi1 = 100;
            byte bytemin = byte.MinValue;   // 0
            byte bytemax = byte.MaxValue;   // 255 olur.
            //sayi1 = 256;    //Burada hata alırız. Çünkü byte veri tipi 255 i en son içinde tutabilir.

            int sayi2 = 256;
            int intmin = int.MinValue;
            int intmax = int.MaxValue;

            int sayi3 = sayi1;      //Burada yaptığımız şeye bilinçli tür dönüşümü adı verilmektedir.

                        


        }
    }
}
