using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37___Hash_Set
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Hashset uygulamasını yapacağız: 

            var sesliHarf = new HashSet<char>() 
            {
                'e','u','ü','ı','i','b'
            };

            //Ekleme
            sesliHarf.Add('a');
            sesliHarf.Add('o');
            sesliHarf.Add('ö');

            KoleksiyonYazdir(sesliHarf);

            //Silme
            sesliHarf.Remove('b');
            KoleksiyonYazdir(sesliHarf);
            Console.WriteLine();

            var alfabe = new List<char>();
            for (int i = 97; i < 123; i++)
            {
                alfabe.Add((char)i);
            }
            KoleksiyonYazdir(alfabe);

            Console.ReadKey();
        }
        static void KoleksiyonYazdir(ICollection<char> koleksiyon)
        {
            Console.WriteLine();
            foreach (char k in koleksiyon)
            {
                Console.Write($"{k,5}");
            }
            Console.WriteLine();
            Console.WriteLine($"Eleman sayısı: {koleksiyon.Count}");
        }
    }
    
}

/*
 * Sorted list yapısına benzer bir yapı sergilemektedir.
 * SortedListten farkı burada elemanları eklerken sıralama yapmamasıdır.
 * Generic sınıfına aittir. Boxing unboxing yok. Elemanları benzersizdir. 
 * Küme işlemlerine yine sortedListteki gibi izin vermektedir.
 * 
 * 
 * 
 */
