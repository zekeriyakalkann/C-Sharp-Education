using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Deger_ve_Referans_Tipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine("{0},{1}", x, y);
            Degistir(ref x, ref y);
            Console.WriteLine("{0},{1}", x, y);     //Buraya kadar olan kısım aslında değer tipli değişkene verilecek basit bir örnektir.
            Console.ReadKey();
        }

        private static void Degistir(ref int x, ref int y)  //Bu şekilde de referans tipli davranış olur ve sayıların yeri main içerisinde ilerleyen kod dahilinde Degistir metodu ya da fonksiyonu ile yapılan değişiklikte kalır. Tekrar eski haline dönmez.
        {
            int gecici = x;
            x = y;
            y = gecici;
            Console.WriteLine("{0},{1}", x, y);
        }
    }
}

//değer tipli yapıların işlemleri stack bölgede gerçekleşmektedir. ve bunları referansa döndürmeden üzerinde bir değişim yaparsak bir sonraki kod satırında değerler ilk haline geri dönecektir.
//Ama bunları referans tipli bir hale getirmek, stack bölgede kalıcı olarak değiştirmemizi sağlar ve değerler tekrardan eski haline dönmez.

//Stack(yığın) bellek = LIFO mantığı vardır. Yani son giren, ilk çıkmaktadır. Otomatik olarak veriyi ortadan kaldırmaktadır. GC gibi bir yapıya sahip değildir. Kendi işini kendi görür.
//Heap (küme) bellek = Daha yavaş çalışır. Stack bellek çok daha hızlıdır ve stackte veriler daha kısa süreli tutulurken heap bellekte daha
//uzun süre tutulmaktadır. Bunu manuel olarak da belirlememiz mümkün olmaktadır. Heap bellekten veri kaldırma işlemi genellikle 
//garbage collector adında bir yapı sayesinde gerçekleşmektedir. Şimdi bir de bu yapının incelemesini yapalım: 
// GARBAGE COLLECTOR: Kullanılmayan nesneleri tespit edip bellekten kaldırır, böylece bellek sızıntılarını önler.
//Erişilemeyen nesneleri kaldırarak heap bölgesinde daha fazla kullanılabilir bellek sağlar.
//Heap bölgesinde boş alanlar oluştuğunda, GC bu boş alanları sıkıştırarak (compacting) birleştirir ve belleği daha verimli kullanır.
//Bu süreç, bellekteki nesnelerin daha düzenli bir şekilde yerleştirilmesini sağlar.
/*
 * Avantajları:

 * Otomatik bellek yönetimi sağlar.

 * Bellek sızıntılarını önler.

 * Geliştiricinin bellek yönetimiyle ilgili endişelerini azaltır.

 * Dezavantajları:

 * Performans maliyeti olabilir, çünkü GC'nin çalışması CPU zamanını kullanır.

 * Belirli zamanlarda bellek sıkıştırma (compacting) süreci nedeniyle gecikmeler yaşanabilir.
 */



