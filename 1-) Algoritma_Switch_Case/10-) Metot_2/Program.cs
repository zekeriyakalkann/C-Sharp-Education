using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Metot_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }

        private static void DinamikMetod()
        {
            Console.Write("{0,-3:0.##}",
                            SeriToplami(12.54, 21.32, 65.81, 43.32, 12.23));    //0.## in anlamı noktadan sonra sadece 2 adet elemanı gösterebilmek için yaptığımız bir formattır.
                                                                                //Kod bu yazım ile daha da dinamik bir hale gelmiş oldu.
        }
        private static double SeriToplami(params double[] seri) //Params ile kodumuzu güzelce dinamik bir hale getirmiş olduk.
        {
            double toplam = 0;
            foreach (var item in seri) 
            {
                toplam += item;
            }
            return toplam;
        }
    }
}
