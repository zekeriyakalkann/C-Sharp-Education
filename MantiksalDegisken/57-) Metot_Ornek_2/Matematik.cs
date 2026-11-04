using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57___Metot_Ornek_2
{
    public class Matematik
    {
        //Topla

        public decimal toplamaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc= sayi1 + sayi2;
            return sonuc;
            
        }

        //Çıkart

        public decimal cikarmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        //Çarp
        public decimal carpmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }

        //Bölme
        public decimal bolmeIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("********* MENÜ *********");
            Console.WriteLine("1-) Toplama");
            Console.WriteLine("2-) Çıkarma");
            Console.WriteLine("3-) Çarpma");
            Console.WriteLine("4-) Bölme");
        }

        public void sonucEkranaYaz(decimal kullaniciSayi1, decimal kullaniciSayi2, decimal sonuc, string operators)
        {
            Console.WriteLine("{0} {1} {2} =  {3}",kullaniciSayi1, operators, kullaniciSayi2, sonuc);
        }


    }
}
