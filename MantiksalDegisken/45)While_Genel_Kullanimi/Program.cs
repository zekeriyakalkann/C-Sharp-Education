using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_While_Genel_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) //Şartımız true olduğu sürece döngümüz çalışmasına devam eder. 
            {
                /*
                 * While döngüsünün sonlanma prensibi = 
                 * 1-) While (false)     Dönene kadar döngü dönmeye devam eder.
                 * 2-) break;       ile kırıldığında döngü sonlanır.
                 * 
                 * Ve bu döngü tipi ile sonsuz bir döngü de oluşturulabilir. Aklımızda bulunsun lütfen :)
                 */

                //Örnek 1 : Ekrana 1'den 10'a kadar olan değerleri yazdıralım.

                int i = 1;
                while (i<=10)
                {
                    
                    Console.Write(i + "\n");
                    i++;
                }
                Console.ReadLine(); 



            }
        }
    }
}
