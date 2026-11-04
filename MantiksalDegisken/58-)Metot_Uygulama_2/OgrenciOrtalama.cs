using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58__Metot_Uygulama_2
{
    public class OgrenciOrtalama
    {
        public void OgrenciOrtalamaHesapla(decimal not1, decimal not2, decimal not3 = 45)//not3 = 45 kısmında not3 değeri girilmeyebilir, sen bunu default olarak atamasını yap anlamına gelmektedir.
            //Ve opsiyonel olan değeri en sona tanımlamaz isek sistem bize hata verecektir. Buna dikkat etmeliyiz. 
        {
            decimal sonuc = OgrenciNotOrtalama(not1, not2, not3);

            Console.WriteLine("Ortalamanız: " + sonuc);

            ortalamaNotDegerlendir(OgrenciNotOrtalama(not1, not2, not3));
        }

        void ortalamaNotDegerlendir(decimal OgrenciOrtalama)
        {
            if (OgrenciOrtalama < 45)
            {
                Console.WriteLine("Dersten kaldınız.");
            }
            else if (OgrenciOrtalama == 45)
            {
                Console.WriteLine("Tebrikler. Dersten geçtiniz.");
            }
            else
            {
                Console.WriteLine("Tebrikler. Dersten geçtiniz.");
            }
        }

        private decimal OgrenciNotOrtalama(decimal Ogrencinot1, decimal Ogrencinot2, decimal Ogrencinot3)
        {
            //decimal sonuc = (Ogrencinot1 + Ogrencinot2 + Ogrencinot3) / 3;
            //return sonuc;
            return (Ogrencinot1 + Ogrencinot2 + Ogrencinot3) / 3;

            //Burada direk olarak return üzerine yazdığımız zaman kod sayısını ve iş yükünü azaltmış oluruz.
            //Daha sade ve düzenli bir kod bloğu oluşmuş olur. 

        }
    }
}
