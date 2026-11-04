using Sinav_Cözüm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Cözüm_Ve_Ders
{
    internal class Program
    {
        List<Kitap> list = new List<Kitap>();
        static void Main(string[] args)
        {
            //Nesne zamanla gelişen değişen bir olgudur. Nesnesiz yaptığımız iş gerçek bir programlamada neredeyse yoktur.
            //Sınıf yemek tarifi ise nesne direk yemek olmaktadır.
            //Değişkeni her yerde kullanacaksak GLOBAL değişken olarak yapmalıyız(classların içerisinde devamlı kullanılan fonksiyonlar gibi)
            //Değişkeni kullanıp bırakacaksak LOCAL değişken olarak yapmalıyız(Main metodu içine yazılan değişkenler)


            Program P1 = new Program();

            Kitap Kitap1 = new Kitap("Roman", 300);
            P1.list.Add(Kitap1);

            Kitap Kitap2 = new Kitap("Bilim", 150);
            P1.list.Add(Kitap2);

            Kitap Kitap3 = new Kitap("Roman", 200);
            P1.list.Add(Kitap3);

            Kitap Kitap4 = new Kitap("Tarih", 250);
            P1.list.Add(Kitap4);

            Kitap Kitap5 = new Kitap("Bilim", 200);
            P1.list.Add(Kitap5);

            Kitap Kitap6 = new Kitap("Tarih", 300);
            P1.list.Add(Kitap6);

            Kitap gecici;
            for(int i = 0; i< P1.list.Count; i++)
            {
                for(int j = 0; j< P1.list.Count-1-i; j++)
                {
                    if (string.Compare(P1.list[j].Adi, P1.list[j+1].Adi) > -1)
                    {
                        gecici = P1.list[j];
                        P1.list[j] = P1.list[j+1];
                        P1.list[j + 1] = gecici;
                    }
                }
            }

            for (int i = 0; i < P1.list.Count; i++)
            {
                for (int j = 0; j < P1.list.Count - 1 - i; j++)
                {
                    if (string.Compare(P1.list[j].Adi , P1.list[j+1].Adi) == 0 &&P1.list[j].SayfaSayisi > P1.list[j+1].SayfaSayisi)
                    {
                        gecici = P1.list[j];
                        P1.list[j] = P1.list[j + 1];
                        P1.list[j + 1] = gecici;
                    }
                }
            }

            for (int i = 0;i< P1.list.Count; i++)
            {
                Console.WriteLine(P1.list[i].Adi);
                Console.WriteLine(P1.list[i].SayfaSayisi);
            }

            Console.ReadKey();
        }
    }
}
