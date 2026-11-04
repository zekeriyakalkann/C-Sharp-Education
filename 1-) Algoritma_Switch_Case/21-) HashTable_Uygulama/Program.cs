using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___HashTable_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TANIMLAMA
            var sehirler = new Hashtable(); //System Collections kısmını hashtable kullanmaktadır.

            sehirler.Add(6, "Ankara");  //Burada key ve value değerlerinin girilmesi zorunludur. Hashtable bu koşullar aracılığı ile faaliyet gösterir
            sehirler.Add(34, "İstanbul");
            sehirler.Add(13, "Bitlis");
            sehirler.Add(33, "Mersin");   //İnt bir değer ataması da bu kısma yapılabilmektedir.

            foreach (DictionaryEntry item in sehirler)  //DictionaryEntry altında key ve value değerlerini barındırdığından ötürü bu şekilde ekranda çıktı almamız mümkündür
            {
                Console.WriteLine($"{item.Key,-5}" +
                    $"- {item.Value,-5}");   //Burada konsolda çıkan dictionaryEntry ifadesi bizim key value pairs yani anahtar - değer çifti ile uğraştığımızı belirtir.
            }

            //Anahtarları alma

            Console.WriteLine("\nAnahtarlar (Keys): ");
            var anahtarlar = sehirler.Keys;

            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            //Değerleri alma

            Console.WriteLine("\nDeğerler (Values): ");

            ICollection degerler = sehirler.Values; //Var veri türünün bir alt türü olduğu için bu şekilde de veri alabiliriz.

            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            //Elemana erişme

            Console.WriteLine("\nElemana erişme");
            Console.WriteLine(sehirler[33]);

            //Eleman silme

            Console.WriteLine("\nEleman silme");
            sehirler.Remove(34);

            foreach (DictionaryEntry item in sehirler)  
            {
                Console.WriteLine($"{item.Key,-5}" +
                    $"- {item.Value,-5}");  
            }

            Console.ReadKey();
        }

    }
}

//F12 tuşuna basmak, Visual Studio'da "Go to Definition" (Tanıma Git) komutunu çalıştırır. Bu komut, seçili sembolün tanımına sizi götürür.
//var anahtar kelimesi, derleyicinin değişkenin türünü otomatik olarak belirlemesini sağlar. Derleyici, bu tür çıkarımını değişkene atanan değere
//göre yapar. Bu durumda, eğer bir var anahtar kelimesiyle tanımlanmış bir değişkenin
//türü ICollection türünde bir değer içeriyorsa, Visual Studio'da F12 tuşuna basarak tür tanımının bulunduğu yere gider.
//Kısaca ICollection var anahtar kelimesinin bir arayüzü olduğu için yukarıda aynı faaliyet ile kullanmamız mümkün olmuştur.
//Önemli bir özelliktir. Dikkat edelim. 