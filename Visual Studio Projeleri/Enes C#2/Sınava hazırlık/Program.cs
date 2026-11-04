using System;

namespace SınavaHazırlık // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden vize ve final bilgilerinin girilerek öğrencinin ortalama notunu hesaplayınız.

            int vize, final;
            double ortalama;
            vize = Convert.ToInt32(Console.ReadLine());
            final = Convert.ToInt32(Console.ReadLine());
            ortalama = (vize + final) / 2;
            Console.WriteLine("Ortalama: " + ortalama);
            Console.ReadKey();














        }
    }
}
