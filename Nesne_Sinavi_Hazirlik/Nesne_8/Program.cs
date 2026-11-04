using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_8
{
    public class Program
    {
        static int oda_sayisi;
        static string ev;
        static void Main(string[] args)
        {
            oda_sayisi = 4;
            ev = "Bitlis";
            Console.WriteLine($"Ev {ev} ilinde {oda_sayisi} oda sayısına sahiptir. ");
            Console.ReadKey();
        }
    }
}
//1 -) Sınıfın bir tane statik kurucusu olabilir.
//2-) statik kurucu parametresizdir.
//3-) Sınıfın ancak statik öğelerine erişebilir.
//4-) Statickurucunun erişim belirteci olmaz.
//Bu özellikler main kısmının içerisinde olduğu class için geçerlidir. Ve static kısmı parametre genel olarak tek başına değişken tanımlamada kullanılırken
//parametre alamamaktadır.

/*
 • Yokediciler yalnızca sınıflar içindir; yapılarda kullanılmaz.
 • Bir sınıfın yalnızca bir tane yokedicisi olabilir.
 • Yokedici aşırı yüklenemez, kalıtımı olamaz.
 • Yokedici çağrılamaz; o kendisi otomatik çalışır.
 • Yokedici değiştirilemez; parametresi yoktur.
 */

