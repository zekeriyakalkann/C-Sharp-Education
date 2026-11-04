using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List();

            Console.ReadKey();
        }

        private static void List()
        {
            //arrayListte bir elemanı kutudan çıkarabilmek için cast yani bilinçsiz tür dönüşümü yapmak gerekir iken
            //List<T> kavramında böyle bir duruma gerek yoktur. Çünkü listenin veri tipi baştan belirlenir.
            //Arraylistte böyle bir durum söz konusu değildir.
            //List<T> burada T li olan kısmın şimdilik generic yani yer tutucu olduğunu bilmemiz yeterli olacaktır.
            //Bu sayede de type yani tip güvenliği sağlanmış olmaktadır. O tipten başka veri listeye eklenemez.


            //List<int> ints = new List<int>();   // bu şekilde bir tanımlama da yapılabilir.

            var sayilar = new List<int>() { 10, 20, 30 }; //Böyle bir tanımlama ve atama daha esnek olur.

            int x = 55;
            //int[] seri = new int[] {65, 70, 75};
            //Eleman ekleme

            sayilar.Add(x); //Böyle de eklemeler yapılabilmektedir.
            sayilar.AddRange(new int[] { 45, 50, 55 }); //Birden fazla eleman ekleme
            //Bu şekilde addrange metodu içerisine de verilerimizi direk bu şekilde ekleyebiliriz.

            //Araya Ekleme

            sayilar.Insert(3, 0);
            sayilar.InsertRange(4, new int[] { 80, 90, 100 });

            //Silme

            sayilar.RemoveAt(3);    //3. indexteki elemanı siler.
            sayilar.RemoveAt(sayilar.IndexOf(55));  //Hem buradaki 55 değerinin index değerini görürüz, hem de bu değeri listeden sileriz.
            //Dolaşma

            foreach (var s in sayilar)
            {
                Console.WriteLine($"{s,-3}");   //Buradaki s direk sayilar listinin içindeki elemanları temsil etmektedir.
            }
        }
    }
}
