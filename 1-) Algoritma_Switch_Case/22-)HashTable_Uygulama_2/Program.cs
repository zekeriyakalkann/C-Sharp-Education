using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22__HashTable_Uygulama_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashTable Uygulama 

            //Başlık alma
            Console.WriteLine("Başlık giriniz: ");
            string baslik = Console.ReadLine();

            //Küçültme
            baslik = baslik.ToLower();

            //HashTable 

            var karakterSeti = new Hashtable()
            {
                {'ç','c'},
                {'ı','i'},
                {'\'','-'},
                {'.','-'},
                {'ğ','g'},
                {'ö','o'},
                {'ü','u'},
                {' ','-'}   //Bu şekilde çiftler halinde tanımlamalar yapabilmekteyiz.
            };

            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
                //Replace komutunun zaten türkçe karşılığı yer değiştirdir. Eski char ifade ile 
                //Yeni char ifadenin yeri değiştirilmektedir.
                //Cast or Casting = tür dönüştürme anlamına gelmektedir.
            }

            Console.WriteLine(baslik);

            //hashtable yapısını bu şekilde buralarda da kullanabilmekteyiz.


            Console.ReadKey();

        }
    }
}
