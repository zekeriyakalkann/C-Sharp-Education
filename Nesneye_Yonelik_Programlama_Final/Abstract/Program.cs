using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Sekil
    {
        public abstract double AlanBul();
        public void BilgiGoster()
        {
            Console.WriteLine("Bu şekiller soyut sınıfına aittir.");
        }
    }

    class Daire : Sekil
    {
        private double yaricap;
        public Daire(double yaricap)
        {
            this.yaricap = yaricap;
        }

        public override double AlanBul() 
        {
            return Math.PI * yaricap * yaricap;

        }
    }

    class Dikdortgen : Sekil
    {
        private double genislik;
        private double uzunluk;
        public Dikdortgen(double genislik, double uzunluk)
        {
            this.genislik = genislik;
            this.uzunluk = uzunluk;
        }

        public override double AlanBul()
        {
            return genislik * uzunluk;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Sekil sekil = new Sekil();  //Soyut bir sınıfın nesne örneği oluşturulamaz. 
            Sekil daire = new Daire(7);
            Sekil d_dortgen = new Dikdortgen(12, 14);
            Daire daire2 = new Daire(3);

            //Sekil sekil1=new Sekil(); // soyut sınıftan nesne oluşturulamaz.
            //sekil1.BilgiGoster();

            daire.BilgiGoster();
            Console.WriteLine(daire.AlanBul());
            d_dortgen.BilgiGoster();
            Console.WriteLine(d_dortgen.AlanBul());
            daire2.BilgiGoster();
            Console.WriteLine(daire2.AlanBul());
            Console.ReadKey();
        }
    }
}
