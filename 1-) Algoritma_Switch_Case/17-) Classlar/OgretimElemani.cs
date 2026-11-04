using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Classlar
{
    //ctrl + tab tuşu ile visual studio üzerinde açık olan projelerden istediğimize gidebiliriz. Kullanışlı bir kısayoldur.
    //CLasslarda da prop özelliğini kullanabiliz. Yani sadece struct yapısına özel bir durum değildir.
    public class OgretimElemani
    {
        //Property / Yani özellik
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        //Property leri komple seçerek de tornavidadan kısa bir yolla constructor oluşumunu sağlayabiliriz. Kod yazmak artık çok basit :)

        public OgretimElemani()
        {

        }
        public OgretimElemani(int sicilNo, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilNo;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }
        public override string ToString()
        {
            //return base.ToString(); //base toStringin temel sınfını yani objeyi temsil eder. ve objenin tostring metodunu bizim için çağırmaktadır.
            return $"{SicilNo,-5} " +
                $"{Adi,-10} " +
                $"{Soyadi,-10} " +
                string.Format("{0,-8}", Cinsiyet == true ? "Bay" : "Bayan");
            //Son dönecek olan ifadenin string olması gerektiğinden ötürü string.format metodu ile bu işlemi gerçekleştirmemiz gerekmektedir.


        }
    }
}
