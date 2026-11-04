using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56__Metotlar_2
{
    public class Ogrenci
    {
        public void ogrenciSelamla() 
        {
            Console.WriteLine("Merhaba Öğrenci!");
        }

        /*
        * Bir metot tanımlamak için gerekli olanlar: 
        * [Erişim Belirleyicileri] //Burası zorunlu değil // < geri dönüş değeri > MetotAdi (Parametreler) 
        * {
        *      //Metodun çalışması için gerekli kodlar 
        * }
        * Erişim Belirleyicileri: 
        * Public
        * Private
        * İntenal
        * Protected
        * İnternal Protected
        */

        //Şimdi bir metot tanımlaması yapalım: 

        private void ogrenciMetot1(string ogrenciAdi, String ogrenciSoyadi) 
        {
            //Girilen parametreleri de ekrana yazdırabilmek için: 

            Console.WriteLine("Öğrenci bilgileri: {0} {1}", ogrenciAdi, ogrenciSoyadi);

            //Metodumuz artık hazır oldu...
        }

        public void ogrenciMetot2()
        {
            ogrenciMetot1("Zekeriya", "KALKAN");
        }

    }
}
