using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme_property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Property nedir : Türkçe karşılığı özelliktir. 
            //Müşteri musteri = new Müşteri();

            //musteri.      //Burada noktayı koyduğumuzda maden gibi bir şey çıkıyor ise bu field ya da değişken olarak adlandırılır. Eğer ingiliz anahtarı gibi bir şey varsa bu da property olarak adlandırılır.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Müşteri musteri = new Müşteri();

            //musteri.KİLO = 79;      //Değer atama yapıyorum. O zaman atamadan ötürü set blokları çalışır.


            //Console.WriteLine(musteri.KİLO);
            //Eğer değer ataması yapmasaydım o zaman da get blokları çalışır.

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            Müşteri m1 = new Müşteri();

            m1.kilo1 = 85;
            m1.kilo2 = 85;

            Console.WriteLine("Property olan kilo : " + m1.kilo1);
            
            Console.WriteLine("Değişken olan kilo :" + m1.kilo2);

            Console.ReadLine();

            //Burada anlatılmak istenen şey property nin açılıp saçılmadan kullanımında değişken ile aynı görevi gördüğüdür.
            



        }
    }
}
