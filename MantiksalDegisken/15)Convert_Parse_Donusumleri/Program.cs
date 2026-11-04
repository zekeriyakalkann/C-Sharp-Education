using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Convert_Parse_Donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin1 = "100";
            int donusum1 = Convert.ToInt32(metin1);
            int donusum2 = int.Parse(metin1);


            string metin2 = "true";

            bool donusum3 = Convert.ToBoolean(metin2);
            bool donusum4 = bool.Parse(metin2);

            string metin3 = null;

            decimal d1 = Convert.ToDecimal(metin3);     //Burada hata almayacağız.
            decimal d2 = decimal.Parse(metin3);     //Burada ise hata alacağız.
            
            //Parse ve Convert arasındaki ayrım aslında burada kendini belli etmektedir...

            //Convert kullanılması bu yüzden daha güvenlidir. Olabildiğince Convert kullanmaya özel gösterelim...

        }
    }
}
