using System;


namespace Nesne_5_Ornek
{
    class Unviersite
    {
        public string Uni_adi = "Bitlis Eren Üniversitesi";
        public int yil = 2007;

        public Unviersite()
        {
            Console.WriteLine($"{Uni_adi}, {yil} tarihinde kuruldu.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            new Unviersite();   //Burada direk olarak yapıcı metot çalıştığı için cw içerisindeki ifade ekranda görünecektir.
            Console.ReadKey();
        }
    }
}
