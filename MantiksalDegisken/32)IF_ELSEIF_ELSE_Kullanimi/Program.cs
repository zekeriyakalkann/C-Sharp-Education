using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_IF_ELSEIF_ELSE_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Else if karar yapısı: Birden fazla karar noktası olduğu durumlarda kullanılmaktadır...

            Console.Write("1.değeri giriniz: ");
            decimal deger1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("2. Değeri giriniz: ");
            decimal deger2 = Convert.ToDecimal(Console.ReadLine());

            decimal toplam = deger1 + deger2;
            //Burada sıralamada dikkat edilmesi gereken nokta mantıksal bir hatanın olmaması gerektiğidir.
            //Kodda hata vermez, çalışır. Lakin mantıksal hata oluşabilir. Bu yüzden kodu yazarken mantıksal sıralamaya dikkat etmemiz gerekmektedir...
            if (toplam > 50)
            {
                Console.WriteLine("Değerler toplamı 50'den büyüktür...");
            }
            else if (toplam == 50)
            {
                Console.WriteLine("Değerler toplamı 50'ye eşittir...");
            }
            else
            {
                Console.WriteLine("Değerler toplamı 50'den küçüktür...");
            }

            Console.ReadLine();

            //Temel yapı bu şekildedir...




        }
    }
}
