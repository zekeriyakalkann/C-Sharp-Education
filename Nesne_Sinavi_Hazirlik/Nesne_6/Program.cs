using System;

namespace Nesne_6
{
    public class Universite
    {
        public string Uni_adi = "Bitlis Eren Üniversitesi";
        public int yil = 2007;

        public Universite()
        {
            Console.WriteLine($"{Uni_adi}, {yil} tarihinde kurulmuştur.");
        }

        public Universite(string UniAdi)
        {
            Uni_adi = UniAdi;
            Console.WriteLine($"{UniAdi}, {yil} tarihinde kurulmuştur.");
        }

        public Universite(string UniAdi, int UniYil)
        {
            Uni_adi = UniAdi;
            yil = UniYil;
            Console.WriteLine($"{UniAdi}, {yil} tarihinde kurulmuştur.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Universite Uni = new Universite("Bitlis Eren Üniversitesi",2009); 
            Console.ReadKey();
        }
    }
}
//Her yapıcı metot altında cw ile yazdırma işlemi yapmadığımızdan ötürü hata aldık.