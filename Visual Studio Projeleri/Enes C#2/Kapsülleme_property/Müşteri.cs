using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme_property
{
    public class Müşteri
    {
        //public int kilo;          //Burası değişken, field ya da alan olarak adlandırılmaktadır. Genelde değişken kullanılmaktadır.

        //public int KİLO       // Yukarı ile tek farkı Get ve Set bloklarının içinde saklı olmasıdır.
        //{

        //    get 
        //    {
        //        return kilo;               
        //    }

        //    set 
        //    {
        //        kilo = value;       // Buradaki value dediğimiz şeyin türkçesi değerdir ve obje ile atama yaptığımız değeri almak için kullanırız.
        //    }
        //Yukarıdaki kısım property nin açılıp saçılmış halidir.

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public int kilo1 { get; set; }  //Property

        public int kilo2;   //Değişken 




    }      

}


