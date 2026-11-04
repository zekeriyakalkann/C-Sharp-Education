using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Buradaki tanımlamaların hepsi dizi tanımlamasına örnek olarak verilebilir.
            int[] sayilar = new int[] { 5, 8, 1, 19, 21, 54, 76, 91, 100, 234, 3 };
            var numbers = Array.CreateInstance(typeof(int), sayilar.Length); //Burada da array dizinin metodunu kullanarak arrayimizin tipini ve genişliğini belirtebilmemiz mümkün olmaktadır.
            var arr = new ArrayList(sayilar);//Array kodu ArrayList kodunun override edilmiş halidir. Ve parametre olarak collection eklediğimiz için arrayListimzi aşağıdaki gibi yazdırmış olduk.
            //numbers.SetValue(5, 0);     //SetValue metodu ile beraber arrayimize indisini de belirterek değer ataması yapabilmekteyiz.
            //numbers.SetValue(8, 1);     //Önce değer, sonra index değeri yazılmaktadır.
            //numbers.SetValue(1, 2);
            //numbers.SetValue(19, 3);
            //numbers.SetValue(21, 4);

            sayilar.CopyTo(numbers,0);  //Burada da sayilar dizisi numbers dizisine kopyalandı. Yanındaki ifade ise hangi indexten başlamayı istediğimizi sormaktadır.


            //Diziler metotlarına uygun uygulamalar

            Array.Clear(sayilar, 2, 2); //Bu şekilde de diziden istediğimiz yerden ve uzunluktan eleman silme işlemini gerçekleştirebiliriz.
            arr.Sort(); //Bu işlemi sayilar dizisi ile numbers dizisi için doğrudan yapamıyoruz. Bunu arraylist için yapabiliriz.
            //arraylistimizi sort fonksiyonu ile sıralamamız mümkün olmaktadır.
            Array.Sort(sayilar);    //Bu şekilde sayılar dizimizi de numbers dizimizi de sıralamış olduk.
            Console.WriteLine(Array.IndexOf(sayilar, 8));   //Bu şekilde dizi içerisindeki bir elemanın kaçıncı indexte olduğunu sorgulayabilirz. Eğer ilgili eleman dizi içerisinde mevcut değilse değer "-1" dönecektir.    
            Array.Sort(numbers);



            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"sayilar [{i}]: " +
                    $"{sayilar[i],-3} " +
                    $"- numbers [{i}]: {numbers.GetValue(i),-3}" +
                    $"arr[{i}] = {arr[i],-3}");    //Setvalue ile atama yaparken getvalue ile değerleri alıyoruz ve bu şekilde arrayimizin içerisinde dönme işlemini gerçekleştirmekteyiz.
            }

            Console.ReadKey();
        }
    }
}
