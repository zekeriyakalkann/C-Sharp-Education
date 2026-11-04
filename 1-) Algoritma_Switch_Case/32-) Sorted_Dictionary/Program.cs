using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33___Sorted_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kitapIndeks = new SortedDictionary<string, List<int>>()
            {
                {"FTP", new List<int>() {3,5,7} },
                {"HTML", new List<int>() {8,10,12} },
                {"CSS", new List<int>() {70,80,90} },
                {"SQL", new List<int>() {70,80} },
                {"ASP.NET", new List<int>() {50,60} },
                {"JQUERY", new List<int>() {3,5,15} },
                //Bu şekilde alfabetik sıraya göre gelmeyen verileri alfabetik sıraya koyarak bize yazdırdığımızda değeri vermektedir. 
            };

            foreach (var k in kitapIndeks)
            {
                Console.WriteLine($"{k.Key}");
                k.Value.ForEach(s => Console.WriteLine("\t >" + s + " pp"));
                //Bu kısımda da ayrı ayrı yazdırma işlemlerini yapmamız gerekmektedir. Bunun sebebi ise SortedDictionary kavramının yapısından kaynaklanmaktadır.
            }

            Console.ReadKey();
        }
    }
}
/*
 * Dictionary ile neredeyse aynı işlevleri ve yapıları gözlemlemekteyiz.
 * Tek fark burada anahtar değer çiftlerini eklerken aynı anda sıralama da yapmaktadır.
 * Bu da performans kaybına yol açabilmektedir. Bunun haricinde tüm yapıları aynıdır. Generic sınıfına aittir vs. şeklinde söyleyebilmekteyiz.
 * 
 * 
 * 
 */
