using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Getter ve setter metotları ve property ile kapsülleme yapılabilir. Bu derste biz getter ve setter metotlarını kullanarak bu işlemi yapacağız.
            //Set ile değer ataması yapılırken Set ile değerleri alma işlemi yapılır. 
            
            Öğrenci ogrenci1 = new Öğrenci();

            ogrenci1.Setisim("Gamze");
            string Gelenisim =ogrenci1.Getisim();     //Get almak olduğu için bunu aynı veri tipi ile karşılamam gerekmektedir. Yoksa değeri ekranda göremeyiz.

            if (Gelenisim == "Gamze")
            {
                Console.WriteLine("İsim Gamze'dir.");
            }
            else 
            {
                Console.WriteLine("İsim yanlıştır.");
            }
            Console.ReadLine();


        }
    }
}
