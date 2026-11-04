using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31___Dictionary_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary tanımlanması

            var telefonKodları = new Dictionary<int, string>()
            {
                {355, "Mersin"},
                {123, "Maraş"},
                {654, "Hatay"},
                {466,"Art"}
            };
            //Ekleme işlemi: 

            telefonKodları.Add(322, "Adana");
            //telefonKodları.Add(322, "Mersin"); // Bu şekilde bir kullanımda çalışma zamanında hata alırız. Kodda bir hata yoktur,
            // build edilirken de bir hata alınmaz, ancak dediğimiz gibi çalışma zamanında TKey ler aynı olacağından
            // ötürü hata alırız. Bunun sebebi de Tkey ler benzersiz olmak zorunda olduğu içindir.

            telefonKodları.Add(212, "İstanbul");
            telefonKodları.Add(216, "İstanbul");

            //Erişme işlemi: 
            telefonKodları[466] = "Artvin"; //Index yapısı olmadığından ötürü bu verinin güncellemesini direk key i ile güncellemekteyiz.

            //ContainKey

            if (!telefonKodları.ContainsKey(312)) //! bu veriyi içermiyor mu anlamına gelmektedir.
            {
                Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil.");
                telefonKodları.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi.");
            }

            //ContainsValue

            if (!telefonKodları.ContainsValue("Bitlis"))
            {
                Console.WriteLine("\aBitlis'in kod bilgisi tanımlı değil.");
                telefonKodları.Add(313, "Bitlis");
                Console.WriteLine("Yeni kod bilgisi eklendi.");
            }

            //Silme: 
            telefonKodları.Remove(322);

            //Girilen verileri dönme
            foreach (var t in telefonKodları)
            {
                Console.WriteLine(t);
            }




            Console.ReadKey();
        }
    }
}

/*
 * System.Collections.Generic sınıfını kullanmaktadır.
 * Generic bir yapıya sahip olduğundan ötürü boxing/unboxing işlemlerini yapamayız.
 * TKey - TValue pairs yani anahtar değer çiftine sahiptir.
 * TKey benzersiz olmak zorunda TValue ise istediğimiz şekilde olabilmektedir.
 * Hashtable ile kıyaslama yaparsak daha performanslı çalıştığını söylemek mümkün olacaktır.
 * Dictionary <TKey, TValue> şeklinde parantez içleri değerler almaktadır.
 */

//Dictionary, linkedList gibi yapıların üstüne gelip f12 bastığımızda tanımına git (go to definition) yani imzasını bize göstermektedir.
//Aslında Dictionary ve linkedList gibi yapılar da birer sınıfı temsil etmektedir. 
//ICollection ve Ienumarable interface lerinin içerir ise burada foreach ile dönmemizde bir sakınca yoktur.

