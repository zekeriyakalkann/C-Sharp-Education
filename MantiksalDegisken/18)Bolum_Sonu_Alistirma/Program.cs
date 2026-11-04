using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Bolum_Sonu_Alistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String olarak verilen veri tipini bool veri tipine dönüştürün.
            string b1 = "True";
            bool a1 = Convert.ToBoolean(b1);
            Console.WriteLine(a1);
            Console.ReadLine();

            // İnt = 100 olan veri tipini float ve byte veri tipine dönüştürün.

            int sayi1 = 100;

            byte s1 = (byte)sayi1;
            float f1 = (float)sayi1;

            //Byte değişken tipi içinde olan veriyi decimal veri tipine dönüştürün.

            byte c1 = 15;
            decimal d1 = (decimal)sayi1;




        }
    }
}
