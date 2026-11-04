using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapıcıMetot
{
    public class Kullanıcı
    {
        private int KullaniciID;
        private string isim;
        private string soyisim;
        private static int maas;

        static Kullanıcı()      //Static ile yapıcı metotta static+ Class ismi kullanılır.
        {
            maas = 2500;
        }

        public Kullanıcı (int _KullaniciID, string _isim, string _soyisim)      //Yapıcı metotta public+ Class ismi kullanılır.
        {
            KullaniciID = _KullaniciID;
            isim = _isim;
            soyisim = _soyisim;

        }
        public void BilgileriGoster()
        {
            Console.WriteLine("Kullancı Bilgiler :");
            Console.WriteLine("ID : "+ KullaniciID);
            Console.WriteLine("İsim :" + isim);
            Console.WriteLine("Soyisim" + soyisim);
            Console.WriteLine("Maaş"+ maas);
        }
        public void zamyap(int Zammiktari)
        {
            Console.WriteLine("Zamdan sonraki maaşı :" + (maas+Zammiktari));

        }


    }
}
