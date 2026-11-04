using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Degisken_Faaliyet_Alanlari
{
    class Program
    {
        static string S2 = "Cemile SOY";
        static void Main(string[] args)
        {
            string S1 = "Zekeriya KALKAN";
            S1 = "İkinci isim= ";
            S2 = "Bir alt";
        }   //Buradaki static içindeki 2 kodlar 2 süslü parantez ile bir blok olarak oluşturulmuştur.

        static void Test()
        {
            //S1        Yaptığımızda buradaki S1 görünmez. Çünkü bu blok içinde tanımlanmamıştır.
            S2 = "Artık erişim sağlandı...";        //Çünkü bir üst bloğunda tanımladım. Bundan dolayı erişim sağlayabilirim...
        }
        //Bu ders sadece bir ön bilgi oluşması için hazırlanmıştır. Daha ilerilerde daha detaylı bir şekilde ele alacağız...

    }
}
