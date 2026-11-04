using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58__Metot_Uygulama_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhabalar.");
            Console.WriteLine("Lütfen adınızı ve soyadınızı giriniz: ");

            string AdSoyad = Console.ReadLine();

            Console.Write("1. notu giriniz: ");

            decimal ogrencinot1 = decimal.Parse(Console.ReadLine());

            Console.Write("2. notu giriniz: ");

            decimal ogrencinot2 = decimal.Parse(Console.ReadLine());

            Console.Write("3. notu giriniz: ");

            decimal ogrencinot3 = decimal.Parse(Console.ReadLine());

            OgrenciOrtalama o1 = new OgrenciOrtalama();

            o1.OgrenciOrtalamaHesapla(ogrencinot1,ogrencinot2); //Normalde burada ogrencinot3 olması gerekirdi, fakat OgrenciOrtalama nesnesi içerisinde o değeri default olarak ayarladığım için hata ortadan kalkmış oldu.
            //Eğer ogrencinot3 değeri girişi buradan yapılırsa 45 değeri bizim girdiğimiz değere göre değişir ve o değer kullanılır.
            Console.ReadKey();
        }
    }
}
