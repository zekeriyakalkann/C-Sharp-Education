using System;
using System.Collections.Generic;
using System.Collections;   //Bu kısmı tanımlamadan Arraylistleri kullanamıyoruz. Çünkü burası arraylist özelliklerini barındıran bir kütüphanedir.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizilerde sadece bir tek veri tipi saklanırken ve
            //boyut bilgisi sabit iken arrayList ve Listlerde sabitlik söz konusu değildir

            //Tanımlama
            /*ArrayList*/ var arrayList = new ArrayList() {
                10, "Zekeriya KALKAN", true, 'e'    //Bu şekilde çok daha hızlı bir şekilde arrayListe eleman eklemesi yapabilmekteyiz.
            };  //Bu şekilde bir tanımlamada örtülü ve daha kısa bir şekilde arraylist tanımı yapabiliriz. 

            //ArrayList ekleme yapma
            //arrayList.Add(10);  //Boxing işlemi yapılır. Yani girilen veriler int, string vs gibi veri tipleri olsa bile hafızada object veri tipinde saklanmaktadır.
            //arrayList.Add("Zekeriya KALKAN");
            //arrayList.Add(true);
            //arrayList.Add('e'); Bu şekilde bir ekleme uzun olur. Daha basit yolu yukarıdaki gibidir.

            //Dolaşma yani ekranda görüntüleme

            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();

            //Dolaşma 2

            int[] dizi = new int[3] {12, 22, 32 };
            arrayList.AddRange(dizi);       //Bir arrayListe 1 den fazla elemanı eklemek için addRange(); komutu kullanılır.
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
            //Elemana erişme

            Console.WriteLine(arrayList[1]);    //Bu şekilde de tek bir elemana aynı dizi mantığı ile erişebilmekteyiz. 
            
            //Elemana erişme - değiştirme
            var x = (int)arrayList[0];  //Unboxing yani kutudan çıkarma işlemi demekteyiz. 
            Console.WriteLine(x+10);

            //Eleman silme
            //arrayList.Remove(10);   //Direk eleman
            //arrayList.RemoveAt(1);  //İndexteki eleman
            arrayList.RemoveRange(3,3); //Belli bir indexten belli adet eleman. 3. indexteki elemanı silerek başlar.
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
