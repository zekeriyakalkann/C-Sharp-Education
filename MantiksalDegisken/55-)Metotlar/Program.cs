using System;   //Usin Sysytemler, bir kütüphane dosyamızı uygulamamızın içerisine eklememize yarar.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _55__Metotlar //Namespace kısmı kütüphanedir class sınıftır ve class altındaki public staticler ise
    //Fonksiyon ya da metot olarak adlandırılmaktadır.
{
    internal class Program
    {
        static void Main(string[] args)     //Main metodunu sistem ilk önce tanır ve kod çalışmaya buradan başlar. Başlangıç metodudur...
        {
            //Şimdi aşağı kısımda oluşturduğumuz metodun nasıl çağırıldığını göreceğiz: 

            Selamla();  //Bu şekilde çağırmaktayız. Parantezlerin içinin boş kalmasının sebebi ise geriye parametre döndürmeyen bir metot tanımlamış
            //olmamızdan kaynaklanmaktadır...

            Ogrenci ogrenci = new Ogrenci();    //Ogrenci burada obje yani nesne konumuna gelmiştir.
            ogrenci.SelamlaOgrenci();

            //Şimdi Öğrenci bilgilerini içeren metoda ulaşmaya çalışacağız: 

            ogrenci.OgrenciMetot2();    //Oluşturulan parametrelerin girişini burada sağlamış bulunmaktayız.

            
            
        }

        static void Selamla()   //Buradaki void kısmı geriye herhangi bir parametre döndürmeyecek anlamına gelmektedir.
        {
            Console.WriteLine("Merhaba.Ben bir metodum.");
        }
        


    }
}
