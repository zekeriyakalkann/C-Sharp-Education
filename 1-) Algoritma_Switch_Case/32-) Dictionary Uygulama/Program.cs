using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32___Dictionary_Uygulama
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Dictionary

            var personelListesi = new Dictionary<int, Personel>() 
            {
                {101, new Personel("Hüseyin", "Elçi", 25000) } 
            };
            personelListesi.Add(100, new Personel("Zekeriya", "Kalkan", 100000));

            foreach (var p in personelListesi)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}
