using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public class Hesaplayici
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }

        public double Topla(double a, double b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hesaplayici h = new Hesaplayici();

            Console.WriteLine(h.Topla(3, 5)); // Çıktı: 8

            Console.WriteLine(h.Topla(3.5, 4.2)); // Çıktı: 7.7
            
            Console.ReadKey();

            //Bu kısım statik polimorfizm olarak adlandırılmaktadır. Derleme sırasında hangisi uygun ise ona göre
            //hareket etmektedir.
        }
    }
}
