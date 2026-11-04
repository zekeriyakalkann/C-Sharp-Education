using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Temel bir veri yapısıdır. 
            //Sabit boyutludur. Dizi tanımı yapabilmek için boyutunu belirlemeliyiz. Çünkü bellekte kapladığı fieldı belirlememiz gerekmektedir.
            //Aslında diziler boyutlarına göre değişim yaşadığında birer matrisi andırırlar.

            int[] numaralar = new int[5] { 3, 5, 7, 8, 10};   //Bu şekildeki bir kullanım da bizim işimize yaramaktadır.

            //Referans tipli veri tiplerini başlatmamız gerekmektedir. Nasıl başlatırız ? 

            //numaralar = new int[3]; //Bu şekilde new anahtar sözcüğü yardımı ile başlatabiliriz. 

            for (int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine($"numaralar[{i}] = " +
                    $"{numaralar[i]}");     //Bu şekilde kodlarımızı çok daha esnek bir seviyede yazabiliriz.
            }   

            Console.ReadKey();
        }
    }
}
