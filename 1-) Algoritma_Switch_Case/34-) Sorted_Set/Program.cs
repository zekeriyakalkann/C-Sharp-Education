using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _34___Sorted_Set
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new SortedSet<string>();

            //Ekleme

            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet eklendi.");
            }

            else
            {
                Console.WriteLine("Mehmet listeye eklenemedi! ");
            }

            Console.WriteLine("{0}",
                list.Add("Ahmet") == true ? 
                "Ahmet eklendi." : "Ahmet listeye eklenemedi! ");

            list.Add("Zekeriya");
            list.Add("Ali");
            list.Add("Cemile");
            list.Add("Muharrem");

            list.Remove("Ali");
            //list.RemoveWhere(deger => deger.Contains("a")); //Bu şekilde bir kullanımda string bir ifadenin içerisinde eğer küçük a var ise bunları silecektir.
            list.RemoveWhere(deger => deger.StartsWith("Z")); //Büyük Z ile başlayan kayıtları siler. 
            Console.WriteLine("\nİsimler listemiz:\n ");
            foreach (string l in list)
            {
                Console.WriteLine(l);
                //Burada listemizi rahatça bir şekilde dönebilmekteyiz. Çünkü key-value pairs ile çalışan bir sistem değildir. Aynı liste gibi çalışmaktadır.
            }

            Console.WriteLine($"\nListemizin eleman sayısı: {list.Count}");
            Console.ReadKey();
        }
    }
}

/*
 * Generic sınıfı altında yer alır.
 * Boxing/Unboxing yok.
 * Elemanları unique olmalıdır.
 * Sıralamayı ekleme esnasında kendisi otomatik olarak yapmaktadır.
 * Add() ekleme yaparken normalde void olarak bu cevap bize gelirken SortedSet kavramında bool olarak gelir. Eğer bir değer listeye eklenmiş ise o değeri listemize tekrar eklememize izin vermez. Kontrol mekanizması gibi çalışmaktadır.
 * Dinamik bir yapıya sahiptir.
 * Kesişim, birleşim, ayrışım, altkümeler... gibi yapıları sorgulayabileceğimiz bir kavram olarak karşımıza çıkmaktadır. 
 * Kısaca kümeleme ile ilgili işlemlerde SortedSet yapımız kullanılmaktadır ve çok da faydalı bir yapıdır. Dikkat edelim. Lazım olabilir. 
 * 
 *
 */
