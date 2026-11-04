using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69___Static_Kavramı
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string emailAdres { get; set; }

        public void Test()
        {
            Console.WriteLine("Nesne örneği alındıktan sonra çalışan metot");
            Test2();
            //Static olan metotları çağırabilir.
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne örneği ALINMADAN çalışabilen metot.");
            //static olmayan metotları, alanları, kısaca nesne oluşturulmadan görülemeyen yerleri static metodu çağırıp kullanamaz...
        }
    }
}


