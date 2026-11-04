using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Bilincsiz_Tur_Donusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 300;
            int intmin = int.MinValue; 
            int intmax = int.MaxValue;

            byte sayi2 = (byte)sayi1;       //Buna bilinçiz tür dönüşümü denir. Değer hatalı gelse bile kodda görünmez. Çalıştırdığımız zaman hatayı alırız...
            Console.WriteLine(sayi2);
            Console.ReadLine();
            //Burada hata alıyoruz. Çünkü 300 değerini byte alamamaktadır...
            

        }
    }
}
