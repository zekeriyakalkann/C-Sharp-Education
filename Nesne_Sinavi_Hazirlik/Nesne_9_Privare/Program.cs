using System;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace Nesne_9_Privare
{
    class Car
    {
        private string araba = "TOGG";


        class Program
        {
            private string araba = "MERCEDES";
            static void Main(string[] args)
            {
                var ArabamBenimCanımBenim = new Car();
                Console.WriteLine(ArabamBenimCanımBenim.araba); //Bu şekilde bir kullanımda arabanın modeline erişebilmekteyiz.
                var obj = new Program();
                Console.WriteLine(obj.araba);   //Böyle de kullanılabilmektedir. main kısmını içerisinde bulunan private değişkenlere public gibi erişim sağlayabilmekteyiz.
                Console.ReadKey();
            }
        }
    }
}
