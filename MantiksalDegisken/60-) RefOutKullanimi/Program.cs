using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59___RefOutKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0;
            degerAta(ref sayi1);
            //Burada ref anahtar sözcüğü ile yapılan atamada stake bölgede 2 ayrı 10 değerini değil de tek
            //10 değerini sistemde tutmamız sağlandı. Yani aslında işlemcimizin yükü bu sayede azaltılmış oldu.
        }

        static void degerAta(ref int gelenDeger)
        {
            gelenDeger = 10;
        }
    }
}
