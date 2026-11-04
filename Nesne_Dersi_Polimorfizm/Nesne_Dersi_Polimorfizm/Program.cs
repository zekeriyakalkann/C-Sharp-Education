using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Dersi_Polimorfizm
{
    public class Hayvan
    {
        public virtual string SesCikar()
        {
            return "Hayvan ses çıkarıyor...";
        }
    }
    public class Kopek : Hayvan
    {
        public override string SesCikar()
        {
            return "Köpek ses çıkarıyor...";
        }

    }

    public class Kedi : Hayvan
    {
        public override string SesCikar()
        {
            return "Kedi ses çıkarıyor...";
        }
    }
    public class Topla
    {
        public int Toplam(int a, int b)
        {
            return a + b;
        }

        public double ToplaDouble(double a, double b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        void NewMethod()
        {
            var T = new Topla();

            int toplam = T.Toplam(2, 5);
            double toplam2 = T.ToplaDouble(3.5, 4.1);

            Console.WriteLine($"İnt toplamlar: {toplam}");

            Console.WriteLine($"Double toplamları: {toplam2}");
        }
        static void Main(string[] args)
        {
            Hayvan hyv1 = new Kopek();

            Console.WriteLine(hyv1.SesCikar());

            Hayvan hyv2 = new Kedi();

            Console.WriteLine(hyv2.SesCikar());

            Hayvan hyv3 = new Hayvan();

            Console.WriteLine(hyv3.SesCikar());

            Console.ReadKey();


        }
    }

}