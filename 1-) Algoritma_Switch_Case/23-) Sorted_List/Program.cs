using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23___Sorted_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList temeller
            //Tanımlama
            var liste = new SortedList()    
            {
                {1,"Bir"},
                {3,"Üç"},
                {2,"İki"},
                {4,"Dört"},
                {12,"On iki"},
                {7,"Yedi"},
                {5,"Beş"}
            };

            //Yazdırma
            foreach (DictionaryEntry item in liste)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
                //Yukarıda verilen düzensiz liste otomatik olarak düzenlenir ve o şekilde çıktı karşımıza çıkar 
            }

            Console.WriteLine("Listedeki eleman sayısı : {0}",liste.Count);
            Console.WriteLine("Listenin kapasitesi     : {0}",liste.Capacity);
            liste.TrimToSize(); //listeye başka eleman eklemeyecek isek bu şekilde bellekte eleman sayısından fazla olarak yer tutulmasının önüne geçebiliriz.
            Console.WriteLine("Listenin kapasitesi     : {0}", liste.Capacity);

            //Erişme
            //Key
            Console.WriteLine(liste[12]);   //Anahtar ile erişimi bu şekilde yapmaktayız.

            //İndis ile 
            Console.WriteLine(liste.GetByIndex(3)); //İndis ile erişim
            
            // Key alma
            Console.WriteLine(liste.GetKey(2));

            //Listede sondaki elemanı almak
            Console.WriteLine(liste.GetByIndex(liste.Count-1)); //Eleman sayısının 1 eksiği listedeki son index değerini bize verecektir.

            //Listedeki son anahtarı almak
            Console.WriteLine(liste.GetKey(liste.Count-1));

            //Eleman kaldırma
            liste.Remove(12);
            

            //Anahtarları alma
            var anahtarlar = liste.Keys;
            Console.WriteLine("\nAnahtarlar : ");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            //Değerleri alma
            var degerler = liste.Keys;
            Console.WriteLine("\nDegerler : ");
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            //Eleman güncelleme

            if (liste.ContainsKey(1))
            {
                liste[1] = "One";
            }

            foreach (DictionaryEntry item in liste)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.ReadKey();

        }
    }
}
//Non generic bir yapıya sahiptir (object veri tipini kullanmaktadır.)
//Key - Value pairs kullanır (hashtable gibi)
//HashTabledaki farklarından birisi keylere göre sıralama yapmamızdır.Ekleme yapıldığında doğrudan sıralama işlemi yapılmaktadır.
//Hem keyler ile hem de indisler ile elemanlara erişim mümkündür. (hashtable dan başka bir farkıdır.)
//IndexOfKey gibi bir yapı ile anahtarı alıp indis değerine erişimimiz mümkündür.
//IndexOfValue değeri de hangi indexte ne değerin olduğunu bize göstermektedir.
//getkey ile indisi verip anahtar değerini alabilmekteyiz.
//DictionaryEntry den key ve value değer çiftine erişim sağlamaktayız.
