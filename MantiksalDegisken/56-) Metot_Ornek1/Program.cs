using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _56___Metot_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program Ogrenci1 = new Program();   //Program kısmı metotların özelliklerini barındıran classtır. Ogrenci1 kısmı oluşturulan
                                                //nesneye verilen isimdir. New kısmı nesnenin oluşmasını sağlayan kısımdır. Program() kısmı ise yapıcı metotları çağırmamıza yarayan bölümümüzdür. Saygılarım ile :)
            Ogrenci1.OgrenciMetot1("Zekeriya", "Kalkan");
            Console.ReadKey();
        }

        public void OgrenciMetot1(string ogrenciAdi, string ogrenciSoyadi)
        {
            Console.WriteLine("Öğrenci Bilgileri: {0} {1}",ogrenciAdi, ogrenciSoyadi);
            OgrenciMetot2();

        }   //eğer buradaki public private yapılır ise sadece class içerisinde görünür ve kullanılabilir. Dış dünyaya kapanmış olur.

        private void OgrenciMetot2()
        {
            Console.WriteLine("Öğrenci bilgileri alınmıştır.");
        }
    }
}
/*Şimdi bir metot tanımlaması yapabilmek için ihtiyacımız olan şeyleri öğreneceğiz: 
 * 
 * 
 * [Erisim Belirleyicisi] <Geri Donus Degeri> (Parametreler)
 * {
 *      //Metot için gereken kodlar
 * }
 * 
 * Erişim Belirleyicileri: 
 * 
 * Public: Herkese açık olan bir erişim belirleyicisidir. 
 * Private: Olşuturan metot ya da veri tipinin oluşuturulan class içerisinde kullanılmasına olanak vermektedir. 
 * Protected: Kalıtım tarafında kullanılan bir erişim belirleyicisidir. 
 * İnternal: İlgili kütüphane içerisindeki classa ulaşmamızı sağlamaktadır.
 * İnternal Protected: İlgili kütüphane içerisindeki classa ulaşmamızı sağlamaktadır (Kalıtım ile).
 *
 */










