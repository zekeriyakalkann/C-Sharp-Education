using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OPERATÖRLER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Toplama operatörü (+)
            // int  + string (string)
            // string + int (string)

            int s1 = 10;
            int s2 = 20;
            int toplam = s1 + s2;       //Bunları matematiksel olarak toplar.
            Console.WriteLine(toplam);

            byte s3 = 10;
            byte s4 = 10;
            //byte bytetoplam = s3 + s4;  //Burada hata alıyoruz. Çünkü byte veri tipi çok küçük bir veri tipidir ve bu işlemin sonucunu bir üstündeki daha kapasamlı bir veri tipi olan int a dönüştürerek sonucu verir.
            int bytetoplam = s3 + s4;


            string metin1 = "Merhaba";
            int s5 = 10;
            string toplamStr = metin1 + s5;     //Üstte belirttiğimiz gibi string + int bize str döner. Bu yüzden stringe atamasını yapmış olduk...

            
            int s6 = 10;
            string metin2 = "Zekeriya";
            string toplamStr2 = metin2 + s6;   //Bir üstteki yorum satırının aynısıdır mantık.






        }
    }
}
