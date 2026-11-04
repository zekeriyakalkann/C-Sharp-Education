using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Is_ve_As_OPERATORLERİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = 50;
            int s2 = 100;

            //is operatörü : Sorgulama yapmamıza yardımcı olur. Bir nevi bool veri tipine benzemektedir.
            //Bool donenDeger = degisken is degiskentipi

            object o1 = s1;       //Bu veri tipi gelen veriyi ilgili veri tipine dönüştürür.
            Console.WriteLine(o1);
            s1 = (int)o1;       //Burası da bilinçsiz tür dönüşümü olarak adlandırılır.

            bool kontrolEt1 = o1 is int;
            bool kontrolEt2 = o1 is byte;

            //as operatörü: Bu operatör aynı zamanda tür dönüşümünü de sağlamaktadır.

            string isimSoyisim = "Zekeriya Kalkan";
            object objectstring = isimSoyisim;
            string sonucStr = objectstring as string;   //Eğer burada sonuç string gelir ise atamayı sonucStr ye yapar. is te sadece kontrol yapılmaktaydı.
        }
    }
}
