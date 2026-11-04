using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28___Queue_Temelleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue tanımlama
            var karakterKuyrugu = new Queue<char>();

            //Ekleme: 

            karakterKuyrugu.Enqueue('a');   //Kuyruğa eleman ekleme 
            karakterKuyrugu.Enqueue('e');
            Console.WriteLine($"Eleman sayisi: {karakterKuyrugu.Count}");

            //Diziye kuyruk yapısının atanması: 

            var dizi = karakterKuyrugu.ToArray();   //Bu şekilde dizimize kuyruk yapısının atamasını yapmış olduk

            //Çıkarma: 

            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
            Console.WriteLine($"Kuyruktan {karakterKuyrugu.Dequeue()} elemanı çıkartıldı");
            //Bir üstteki satırda ilk giren a değeri çıkar. FIFO yapısına uygun olarak çalışmaktadır.
            Console.WriteLine($"Eleman sayisi: {karakterKuyrugu.Count}");
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");

            Console.ReadKey();
        }
    }
}



//Queue <T> yapısını kullanmaktadır. System.Collections.Generic Kütüphanesini kullanmaktadır.
//Generic bir yapıya sahip olduğu için boxing unboxing işlemlerini gerçekleştirmez.
//First in first out (ilk gelen ilk çıkar) FIFO yapısına göre çalışmaktadır.
//İşletim sistemi çalışma önceliğini belirlemede kullanılır, ağ yazıcıları, mesaj kuyrukları,
//Buffer(tampon, ön bellek yapıları) nda kullanılmaktadır.
//Kuyruk yapısı olarak geçmektedir. Dikkat edelim ******

 