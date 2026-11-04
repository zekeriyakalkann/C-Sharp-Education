using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_Ornek
{
    internal class Alanlar
    {
        public int En { get; set; }
        public int Boy { get; set; }
        virtual public string Islem { get; set; }

        public Alanlar()
        {
            En = 0; Boy = 0;
            Islem = "Hesaplama";
        }

        virtual public int AlanBul()
        {
            return 0;
        }
    }

    internal class Ucgen : Alanlar
    {
        public override string Islem { get; set; }
        public Ucgen(int a, int b)
        {
            base.En = a;
            base.Boy = b;
            Islem = "Üçgen Alanı";
        }

        public override int AlanBul()
        {
            return (En * Boy) / 2;
        }
    }

    internal class Dikdortgen : Alanlar
    {
        public override string Islem { get; set; }

        public Dikdortgen(int a, int b)
        {
            base.En = a;
            base.Boy = b;
            Islem = "Dikdörtgen Alanı";
        }

        public override int AlanBul()
        {
            return En * Boy;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Alanlar a1 = new Ucgen(4,8);
            Console.WriteLine(a1.AlanBul());
            Console.WriteLine(a1.Islem);
            Alanlar a2 = new Dikdortgen(4,8);
            Console.WriteLine(a2.AlanBul());
            Console.WriteLine(a2.Islem);
            Alanlar a3 = new Alanlar();
            Console.WriteLine(a3.Islem);
            Console.ReadKey();
        }
    }
}
