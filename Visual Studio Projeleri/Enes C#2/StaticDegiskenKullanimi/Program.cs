using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDegiskenKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan c1 = new Calisan();
            c1.calisanID = 1;
            c1.isim = "Gamze";
            c1.soyisim = "Mastarcıoğlu";

            Calisan.Maas = 150000;

            Console.WriteLine("Çalışan ID :" + c1.calisanID);
            Console.WriteLine("Çalışan adı :" + c1.isim);
            Console.WriteLine("Çalışan soyadı : " + c1.soyisim);
            Console.WriteLine("Çalışanın maaşı : " + Calisan.Maas);     //Aynı static metot kullanımındaki mantık geçerlidir.
            Console.ReadLine();
        }
    }
}
