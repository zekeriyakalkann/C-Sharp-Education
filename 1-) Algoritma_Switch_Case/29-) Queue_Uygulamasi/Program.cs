using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29___Queue_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sesliHarfler = new List<char>()
            {
                'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'
            };

            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();

            foreach (var k in sesliHarfler)
            {
                Console.WriteLine();
                Console.WriteLine($"{k,-5} kuyruğa eklensin mi [e/h] ");
                secim = Console.ReadKey();
                Console.WriteLine();
                if (secim.Key == ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"\n{k,-5} kuyruğa eklendi.");
                    Console.WriteLine($"Kuyruktaki eleman sayısı: {kuyruk.Count}");
                    Console.WriteLine();

                }
            }

            

            Console.WriteLine();
            Console.WriteLine("Kuyruktaki elemanları çıkarmak için esc tuşuna basınız: ");
            secim = Console.ReadKey();

            if (secim.Key == ConsoleKey.Escape)
            {
                while (kuyruk.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{kuyruk.Peek(),-5} elemanı kuyruktan çıkartılıyor...");
                    Console.WriteLine($"{kuyruk.Dequeue(),5} elemanı kuyruktan çıkartıldı.");
                    Console.WriteLine($"Kuyruktaki eleman sayısı: {kuyruk.Count}");
                }
            }

            Console.WriteLine("Program bitti.");

            Console.ReadKey();
        }
    }
}
