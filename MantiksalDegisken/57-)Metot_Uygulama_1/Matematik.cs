using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57__Metot_Uygulama_1
{
    public class Matematik
    {
        //Basit bir hesap makinesini metotlar ve class yardımı ile yapacağız: 

        //Topla
        public decimal Toplama(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }

        //Çıkarma

        public decimal Cikarma(decimal sayi1, decimal sayi2)
        {
            decimal sonuc= sayi1 - sayi2;
            return sonuc;
        }

        //Çarpma

        public decimal Carpma(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }

        //Bölme

        public decimal Bolme(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1/sayi2;
            return sonuc;
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menü:");
            Console.WriteLine("1-) Toplama" );
            Console.WriteLine("2-) Çıkarma");
            Console.WriteLine("3-) Çarpma");
            Console.WriteLine("4-) Bölme");
            Console.WriteLine("Lütfen değer seçiniz:");
        }


    }



}
