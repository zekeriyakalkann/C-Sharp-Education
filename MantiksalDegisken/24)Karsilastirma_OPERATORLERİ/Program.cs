using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Karsilastirma_OPERATORLERİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Büyüktür ( > ) operatörü : 
            //Bool tipi olarak dönüş yapar. Çünkü kıyaslama yapmaktadır. Ve karar verir.

            int s1 = 100;
            int s2 = 150;

            bool sonuc = s1 > s2;

            //Küçüktür (<) operatörü
            //Yine bool döner . Kıyaslama yapar ve karar verir.

            int s3 = 100;
            int s4 = 200;

            bool sonuc2 = s1 < s2;

            // Eşittir (==) ve eşit değildir (!=) operatörleri : 
            // = Bu atama operatörüdür eşittir ile karıştırmayalım. 

            bool kontrol1 = s1 == s2;
            bool kontrol2 = s1 != s2;

            //>= operatörü :
            //Bool döner. Bu operatörlerde hep bool döner. Çünkü kıyaslama yapmaktadır.

            bool buyukesitsonuc = s3 >= s4; //Burada 2 karşılaştırma yapmaktadır. 

            //<= operatörü : 
            //Bool veri tipinde cevabımız yine dönecektir.

            bool kucukesitsonuc = s3 <= s4;

            //Şeklinde bu operatörler kullanılmaktadır. 
            //Hep bool dönecek diikat edelim !!!!







        }
    }
}
