using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Alanlar
    {
        public int En { get; set; }
        public int Boy { get; set; }
        virtual public string Islem { get; set; }

        public Alanlar()
        {
            En = 0;
            Boy = 0;
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
        public Ucgen (int a, int b)
        {
            base.En = a;
            base.Boy = b;
            Islem = "Üçgen alan hesaplama";
        }

        public override int AlanBul()
        {
            return En + Boy / 2;
        }
    }

    internal class Dikdortgen : Alanlar
    {
        public override string Islem { get; set; } = "Dikdörtgen hesaplama";

        public Dikdortgen(int a, int b)
        {
            base.En = a;
            base.Boy = b;

            Islem = "Dikdörtgen hesaplama";
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
            Alanlar alan1 = new Ucgen(5,6);
            int UcgenAlan = alan1.AlanBul();
            Console.WriteLine(UcgenAlan);

            Alanlar alan2 = new Dikdortgen (5,6);
            int DikdortgenAlan = alan2.AlanBul();
            Console.WriteLine(DikdortgenAlan);

            Alanlar alan3 = new Alanlar();
            string alan = alan3.Islem;

            Console.WriteLine(alan);
            Console.ReadKey();

        }
    }
}
