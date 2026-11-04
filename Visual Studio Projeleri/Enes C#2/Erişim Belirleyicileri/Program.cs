using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erişim_Belirleyicileri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Müşteri musteri1 = new Müşteri();       //Obje tanımlanırken burada classın ismi değiştirilemden aynen başa yazılmalı ve sonrasında
                                                    //objemizin ismini belirleyip ilerlememiz gerekmektedir.
            musteri1.isim = "Gamze";
            musteri1.soyisim = "MASTARCIOĞLU";
            musteri1.maasdegeri = 100000;
            musteri1.cinsiyet = "Kız";              //Burada yaşı private olduğu için tanımlayamıyoruz. Sadece private ın tanımlandığı class
                                                    //İçinde erişim sağlanabilir.




        }
    }
}
