using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51__Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi kavramı = [] ile dizileri tanımlamaktayız...
            /*string[] ogrenci = new string[5];*/   //Bu bir dizi tanımlama örneğidir...

            string[] ogrenciIsim = new string[5];

            // Nasıl değer ekleyebiliriz ? 
            // 1 2 3 ..... 10
            // 0 1 2 3 4 5 6 7 8 9 10
            /*
             *5 elemanlı bir dizinin elemanlarına ulaşmak için
             *
             * [0]      bu index değerlerini kullanmaktayız..
             * [1]
             */

            ogrenciIsim[0] = "Zekeriya Kalkan";
            ogrenciIsim[1] = "Hüseyin Nazligül";
            ogrenciIsim[2] = "Hüseyin Elçi";
            ogrenciIsim[3] = "Cemile Soy";
            ogrenciIsim[4] = "Mustafa Kalkan";

            //Console.WriteLine(ogrenciIsim[0]);

            //Oluşturmuş olduğumuz dizimizin elemanlarını ekrana yazdıran C# kodunu ForEach ile birlikte yazalım..

            foreach (string s in ogrenciIsim)       //Burada da değeri kendisi arttırmaktadır. Bizim ++ operatörü kullanmamıza gerek yoktur...
            {
                Console.WriteLine(s);
            }
            
            //Aynı işlemi for döngüsü yardımı ile yapalım...

            for(int i = 0; i < ogrenciIsim.Length; i++)     //Burada i<= yapmamızın sebebi index değerinin 0 dan başlamasıdır...
            {
                Console.WriteLine(ogrenciIsim[i]);
            }
            Console.ReadLine();








        }
    }
}
