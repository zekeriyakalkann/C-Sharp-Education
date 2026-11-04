using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_kapsülleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel();   //Burada objeyi oluşturduk get in değerleri alablimesi için
            p1.TCKİMLİKNO = "12345654545";
            Console.WriteLine("Tc kimlik numaranız : "+ p1.TCKİMLİKNO);
            Console.ReadLine();
        }
    }
}
