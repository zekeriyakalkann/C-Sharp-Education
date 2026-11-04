using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_ForEach_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Foreach yalnızca diziler ve nesneler için kullanılabilir. Dikkat edelim...

            string[] isimler = new[] { "Zekeriya", "Gamze", "Cemile", "Mustafa", "Nisa" };

            //  foreach (string s in isimler) : Burada anlatılmak istenen isimler dizisinin içinde dönülecek
            // Dönerken s değişkeni bu değerlere erişip ekrana yazdırabilmemiz için tutulacaktır.
            // String de bu dizinin veri tipi olarak adlandırılmaktadır...

            foreach (string s in isimler)
            {
                Console.WriteLine(s);
            }
            Console.Clear();

            // ForEach genel kullanımı bu şekildedir.








        }
    }
}
