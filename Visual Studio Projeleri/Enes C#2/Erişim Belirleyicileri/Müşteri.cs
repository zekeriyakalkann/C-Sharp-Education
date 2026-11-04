using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Erişim_Belirleyicileri
{
    public class Müşteri
    {
        public string isim;
        public string soyisim;
        public int maasdegeri;
        public string cinsiyet;
        private int yas;

        public Müşteri()            //Burası yapıcı metot olarak adlandırılır.
        {
            Console.WriteLine("Müşteri sınfının yapıcı metodu çalıştı...");
        }


        public void musteribilgilerinigoster()
        {
            Console.WriteLine("Müşterinin ismi : " + isim);
            Console.WriteLine("Müşterinin soyismi : " + soyisim);
            Console.WriteLine("Müşterinin maaşı : " +  maasdegeri);
            Console.WriteLine("Müşterinin cinsiyeti : " + cinsiyet);
            Console.WriteLine("Müşterinin yaşı : " + yas);

        }
        private void isimsoyisimyazdir(string musteriisim, string musterisoyisim)
        {
            Console.WriteLine("Müşterinin ismi ve soyisimi : "+  musteriisim + " "+ musterisoyisim);

        }
    }
}
