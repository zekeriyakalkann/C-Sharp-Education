using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringdegiskentipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Burada dikkat edilecek en önemli nokta girilecek metnin iki tırnak içerisine yazılması gerektiğidir.
            string isimSoyisim = "Gamze MASTARCIOĞLU";
            Console.WriteLine(isimSoyisim);

            isimSoyisim = "Zekeriya KALKAN";
            Console.WriteLine(isimSoyisim);
            
            

            string buyukKarakter = isimSoyisim.ToUpper();       //Tüm harfleri büyütür.
            Console.WriteLine(buyukKarakter);
            
            string buyukKarakter2 = isimSoyisim.ToUpper();      //Tüm harfleri küçültür.
            Console.WriteLine(buyukKarakter2);

            string buyukKarakter3 = isimSoyisim.Substring(1,3);     //1.İndexten başla ve 3 karakter al anlamına gelmektedir.
            Console.WriteLine(buyukKarakter3);


            Console.ReadLine();

        }
    }
}
