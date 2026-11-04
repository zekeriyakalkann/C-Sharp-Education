using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var als = new Alistirma();
            var als2 = new Alistirma();
            als.b = 17;
            Console.WriteLine(als.b);
            Console.WriteLine(als2.b);
            Alistirma.a = 25;
            Console.WriteLine(Alistirma.a);
            Console.ReadKey();
        }
    }

    class Alistirma
    {
        public static int a = 15;
        public int b = 15;

        public Alistirma()
        {
            Console.WriteLine("Hoşgeldiniz!!!");
        }
    }
}
