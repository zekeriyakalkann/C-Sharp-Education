using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tanımlama - Atama
            var liste1 =
                new List<OgretimElemani>()
                {
                    new OgretimElemani(101,"Zekeriya", "Kalkan", true),
                    new OgretimElemani(102,"Gamze", "Çiçek",false),
                    new OgretimElemani(103,"Aylin", "Geniş", false),
                    new OgretimElemani(104,"Hüseyin", "Elçi", true),
                    new OgretimElemani(105,"Ömer", "Erdem", true),
                    new OgretimElemani(106,"Muharrem", "Soy", true),
                };

            Console.WriteLine("Liste 1: ");
            liste1.ForEach(ogr => Console.WriteLine(ogr));  // lambda ifadesi ile tanımlama
            Console.WriteLine();
            List<OgretimElemani> liste2 = liste1;
            Console.WriteLine("Liste 2: ");

            liste2.ForEach(ogr => Console.WriteLine(ogr));  //Lambda ifadesinin kullanımı aslında bu kadar basit bir olaydır. Abartılacak bir durumu yoktur. Saygılarımla...
            liste2.Add(new OgretimElemani(107, "Hüseyin", "Ayata", true));

            Console.WriteLine("Liste 1: ");
            liste1.ForEach(ogr => Console.WriteLine(ogr));

            Console.WriteLine("Liste 2: ");
            liste2.ForEach(ogr => Console.WriteLine(ogr));


            //İşte burada referans tipli davranış gerçekleşir. Class kullanımından ötürü. Önemli bir özelliktir. Lütfen bu ufak nüansları atlamamaya özen gösterelim...

            Console.ReadKey();
        }
    }
}
//_17___Classlar.OgretimElemani çıktı cw çalıştığında görünür. Görünmesinin sebebi tostring(); metodunun çalışmasıdır.
//Biz bu metodu override ederek ekranda istediğimiz çıktıyı görmeyi sağlayabiliriz. 