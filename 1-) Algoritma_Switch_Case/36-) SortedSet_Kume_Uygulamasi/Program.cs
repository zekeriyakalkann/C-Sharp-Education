using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36___SortedSet_Kume_Uygulamasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SortedSet Küme Uygulamamız
            
            //var A = new SortedSet<int>() {1,2,3,4 };
            //var B = new SortedSet<int>() {1,2,5,6 };
            
            var A = new SortedSet<int>(rastgeleSayiUret(10));
            var B = new SortedSet<int>(rastgeleSayiUret(10));

            #region Yazdırma İşlemlerimiz

            Console.WriteLine();
            Console.WriteLine("A listemizdeki elemanlarımız: ");
            
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }

            Console.WriteLine();
            Console.WriteLine("B listemizdeki elemanlarımız: ");

            foreach (int s in B)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            #endregion



            //Union (birleşim)

            //A.UnionWith(B); //Aslında referans tipli davranıştan ötürü B listesindeki 5 ve 6 elemanlarımız da A listesi üzerine eklenmiş biçimde görünecektir.
            //A.IntersectWith(B); //Burada da kümemizdeki elemanların kesişim noktasını bulabiliriz. 
            //A.ExceptWith(B);    //Burada da sadece A kümesinde bulunan elemanları görebilmekteyiz.
            A.SymmetricExceptWith(B); // Kesişim dışındaki elemanları bize vermektedir.
            Console.WriteLine("\n Kesişim dışı elemanların kümesi: \n ");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            Console.WriteLine($"\n Kesişim dışı elemanların toplam sayısı: {A.Count}");
            Console.ReadKey();
        }
        static List<int> rastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();

            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0, 15));
            }
            return list;

        }
    }
}
