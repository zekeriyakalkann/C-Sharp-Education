using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63___Asiri_Yukleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba dünya");
            Console.WriteLine(true);

            //topla(12, 23);  //Bu şekilde aynı metot isimleri ile farklı değerler isteme işlemine overload yani kodu aşırı yükleme denmektedir.
            ekrandaGoster(topla(12, 33));   //Bu şekilde bir kullanım iç içe metot kullanımıdır. Ve iş hayatında bunu sık sık yapacağız.
            //Lütfen dikkat edelim.
        }

        static void ekrandaGoster(object o )
        {
            Console.WriteLine(o.ToString());
        }

        static int topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static decimal topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            return toplam;
        }

        static string topla(string metin1, string metin2)
        {
            return metin1 + " " + metin2;
        }
    }
}
