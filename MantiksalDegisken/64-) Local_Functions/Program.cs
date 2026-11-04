using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _64___Local_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LocalFunctionKullanimi(12, 23);
        }

        static void LocalFunctionKullanimi(int sayi1, int sayi2)
        {
            int topla(int gelenDeger1, int gelenDeger2)
            {
                return gelenDeger1 + gelenDeger2;
            }

            topla(sayi1, sayi2);
        }

        //Local Function kullanımı bu şekildedir. LocalFunctionKullanimi metodu içerisindeki topla metodu sadece LocalFunctionKullanimi
        //metodu sınırları içerisinde istenildiği kadar kullanılır. Kod karmaşasını azaltmak için bu uygulamaya geçilmiştir.
    }
}
