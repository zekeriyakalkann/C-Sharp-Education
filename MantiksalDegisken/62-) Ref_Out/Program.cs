using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62___Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 0;
            //degerAta(ref sayi1);

            //Aslında ref ve out anahtar kelimeleri değer tipli davranışa sahip olan değişkenleri referans tipli davranışa çevirmemize yaramaktadır.
            //Yani son durumda gelenDeger de sayi1 değişkenimiz de 10 değerine referans olarak gösterilmiş oldular.

            topla("Zekoş", 25, 12, 45, 43, 12, 23, 3, 43, 4, 53);//Bu şekilde params ile dizinin tipini belirledikten sonra
            //istenen veri tipinde istediğimiz kadar değer girişi yapabiliriz.

        }

        static void degerAta(ref int gelenDeger)
        {
            gelenDeger = 10;

        }

        static void topla(string metin1,params int[] sayilar)   //Tekil parametreyi önce verip params ı sonra kullanmalıyız. Çünkü ne zaman bitireceğimizi belli değildir paramsta. 
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];

            }
            Console.WriteLine("Sayıların toplamı: {0}", toplam);
        }
    }
}
