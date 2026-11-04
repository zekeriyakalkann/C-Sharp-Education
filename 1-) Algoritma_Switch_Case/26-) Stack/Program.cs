using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26___Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var karakterYigini = new Stack<char>();

            for (int i = 65; i <= 90; i++)  //ASCII ye göre alfabe sıralaması yapacağız.
            {
                karakterYigini.Push((char)i);
                Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi.");
                Console.WriteLine($"Yığındaki eleman sayısı: {karakterYigini.Count}" );
            }

            //Ek bilgi: Stack i diziye ekleme: 
            var dizi = karakterYigini.ToArray();    //Bu şekilde stack yapısını dizi yapısına eklemiş olduk.
            Console.WriteLine("Yığındaki elemanları çıkarmak için bir tuşa basınız: ");
            Console.ReadKey();

            for (int i = karakterYigini.Count - 1; i > 0; i--)
            {
                Console.WriteLine($"{karakterYigini.Pop()} elemanı yığından silindi");
                Console.WriteLine($"Yığındaki eleman sayısı : { karakterYigini.Count}");
            }

            //Push eleman ekler, peek en üstteki elemanı gösterir, pop ise en üstteki elemanı siler.
            Console.ReadKey();
        }

        

        private static void YiginOrnek()
        {
            //stack oluşturma
            //var karakter = new Stack();Bu şekilde bir kullanımda non generic bir kullanım yapılır ama biz alttaki gibi kullanacağız.
            var karakterYigini = new Stack<char>();

            //Ekleme
            karakterYigini.Push('A');
            Console.WriteLine(karakterYigini.Peek());

            karakterYigini.Push('B');
            Console.WriteLine(karakterYigini.Peek());

            karakterYigini.Push('C');
            Console.WriteLine(karakterYigini.Peek());

            //Silme

            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkartıldı.");
        }
    }
}



/// Stack ile ilgili notlar ///
//Stack<T> şeklinde gösterilir ve system.collections.generic sınıfı altında yer alır.
//Yani generic olarak kullanılır ve veri güvenliği sağlanmış olmaktadır.
//T = Type (tip) = Stack<int> şekinde kullanılabilmektedir.
//Last in first out = LIFO mantığı ile çalışır.
//Fonksiyon çağırımında ve özyinelemeli (recursive) fonksiyonlarda kullanılabilmektedir.
//İşletim sistemi üzerinde en son yapılan ya da kullanılan uygulamaların listesini tutmamıza yardımcıdır. 
//Syntax hatalarının ayırdı için kullanılabilir.
//Ayrıştırma, ters çevirme, hafıza yönetimi, tarayıcı sekmelerinde kullanılabilmektedir.
//Stack yapısına son giren eleman öncekilerin üzerine eklenerek devam eder. Kitaplardan örnek verelim. En alttaki kitabı alabilmek
//için diğer kitapları tek tek kaldırmamız gerekmektedir. Yani LIFO mantığına uyarak ekleme çıkarma uygulamalarını yapmaktayız.