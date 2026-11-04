using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classs_ve_metotlar
{
    internal class Obje
    {
        static void Main(string[] args)
        {
            araba araba1 = new araba(4,"Siyah");
            //araba1.kapisayisi = 4;        //Buradaki değişkenleri şimdi yapıcı metot ile atayacağız.
            //araba1.arabarengi = "Kırmızı";    //Buradaki satırlarda int ve string ile tanımlanan şeylerin değerlerini atadık.

            Console.WriteLine("Kapı sayısı : " + araba1.kapisayisi);
            Console.WriteLine("Arabanın rengi : " + araba1.arabarengi);
            

            //Bu şekilde yapıcı metotlar kullanılır. İlerilerde her noktada bunları kullanacağız. O yüzden buralara dikkat etmeye çalışalım.






            araba1.kapilarikilitle();
            araba1.arabacalistir();           //Buradaki satırlarda ise metotlar içerisindeki veriler alındı.

            Console.WriteLine("Arabanın kapı sayısı : " + araba1.kapisayisi);
            Console.WriteLine("Arabanın rengi : " + araba1.arabarengi);     // Bu satırlar metot önüne yazılır ise burada daha başta çıktı verir.
            Console.ReadLine();
        }
    }
}
