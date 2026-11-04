using System;
using System.Collections;       //ArrayList koleksiyonun çalışabilmesi için bu kütüphaneyi eklememiz gerekmektedir.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList koleksiyon = new ArrayList();     //Ayrı class açmaya gerek yoktur. direk obje olarak tanımlanır ve kullanılır.

            //koleksiyon.Add("Şehla");            //Add ile her türlü değişken girilerbilir string int double vs.
            //koleksiyon.Add("Elçi");
            //koleksiyon.Add("Nazlıgül");
            //koleksiyon.Add("Ayata");

            //koleksiyon.Remove("Elçi");          //Remove ise girilen değişkeni kaldırmaya yarar.

            //int dizisayisi = koleksiyon.Count;  //Burada da döndürme işlemi yapıldığından uygun veri tipine tanımlamasını yaptık.

            //koleksiyon.Clear();         //Dizideki tüm elemanları kaldırır ve bize boş bir sayfa verir

            //bool kontrol =  koleksiyon.Contains("Şehla");       //Contains de bir veri tipinin var mı yok mu olduğunu sorgular. Bool ile beraber kullanılmaktadır.

            // int index = koleksiyon.IndexOf("Ayata");      //Verinin kaçıncı indexte olduğunu bize verir.

            //koleksiyon.Insert(3, "Deniz");          //Bu da dizide istediğimiz bir index değerine veriyi eklememize yaramaktadır.

            //koleksiyon.Reverse();           //Diziyi ters çevirir.

            

            //foreach (string a in koleksiyon)
            //{
            //    Console.WriteLine(a);
                
            //}
            //Console.WriteLine("Dizinin eleman sayısı :" + dizisayisi);
            //Console.WriteLine("Var mı ?"+ kontrol);
            //Console.WriteLine("İNDEX numarası :" + index);
            //Console.ReadLine();




            ArrayList rakamlar = new ArrayList();

            rakamlar.Add(2);
            rakamlar.Add(43);
            rakamlar.Add(1);
            rakamlar.Add(9);
            rakamlar.Add(100);
            rakamlar.Add(23);

            rakamlar.Sort();         //Sayıları küçükten büyüğe sıralar.

            foreach (int i in rakamlar)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

    }
}
