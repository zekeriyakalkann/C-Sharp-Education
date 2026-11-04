using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56__Metotlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci O1 = new Ogrenci();
            //O1.ogrenciSelamla();
            O1.ogrenciMetot2();     //Bu kısmın metodunun erişim belirleyicisi private olarak değiştiği için metot içindeki işlemleri burada yapamayacağız...

        }

    }
}
