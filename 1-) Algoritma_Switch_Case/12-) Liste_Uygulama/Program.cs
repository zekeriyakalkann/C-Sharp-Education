using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Liste_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "Van",
                "Samsun",
                "Ordu"
            };

            //Lambda expression (Lambda ifadeleri) => ifadesi ile bu işlemi yaparız.kısa işlemleri fonksiyon haline getirerek kodu daha okunabilir hale getirir ve anonim fonksiyonlar olarak birçok yerde esneklik sağlar.

            sehirler.ForEach(s => Console.WriteLine(s));

            Console.WriteLine(new string('-', 50)); //Bu şekilde de araya bir ayraç koyduk.

            var iller = sehirler;   //Bu bir referans tipli veri tipi olmuştur. O yüzden 2 listede de yapılan değişiklikler aynı çıktıyı bize verecektir.

            iller.ForEach(i => Console.WriteLine(i));

            sehirler.Add("Sinop");

            Console.WriteLine();

            sehirler.ForEach(s => Console.WriteLine(s));

            Console.WriteLine();

            iller.ForEach(i => Console.WriteLine(i));

            iller.Remove("Ankara");

            iller.ForEach(i => Console.WriteLine(i));

            Console.WriteLine();

            sehirler.ForEach(s => Console.WriteLine(s));

            Console.ReadKey();  //List kullandığımız için referans tipli bir davranış sergilemektedir.
        }
    }
}
