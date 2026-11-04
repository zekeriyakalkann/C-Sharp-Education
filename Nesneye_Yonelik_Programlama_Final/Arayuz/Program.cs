using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arayuz
{
    public interface IArayuz
    {
        void Metot1();
        string Metot2();
    }

    public class Sinif : IArayuz // Bir arayüz tanımı yapıldığında tanımlanan tüm içerisindeki bilgileri kullanmamız gerekmektedir.
    {
        public void Metot1()
        {
            Console.WriteLine("Metot1 uygulandı.");
        }

        public string Metot2() 
        {
            return "Metot2 uygulandı.";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //IArayuz arayuz = new IArayuz(); //Böyle bir kullanım olamaz. Arayüzden nesne türetemeyiz.
            IArayuz arayuz = new Sinif();
            arayuz.Metot1();
            Console.WriteLine(arayuz.Metot2());
            Console.ReadKey();

        }
    }
}
