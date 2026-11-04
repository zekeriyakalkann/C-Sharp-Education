using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamik_Polimorfizm
{
    public class Hayvan
    {
        public virtual void SesiCikar() //Virtual komutu bir metodu türetilmiş sınıflarda tekrar kullanılabilir hale getirmek için kullanılır. Bu şekilde dinamik bir polimorfizm yapısı oluşturulabilir.
        {
            Console.WriteLine("Hayvan sesi çıkıyor...");
        }
    }

    public class Kedi : Hayvan
    {
        public override void SesiCikar()
        {
            Console.WriteLine("Kedi mivaylıyor...");
        }
    }

    public class Kopek: Hayvan
    {
        public override void SesiCikar()
        {
            Console.WriteLine("Köpek havlıyor...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvan h1 = new Hayvan();
            h1.SesiCikar();
            Hayvan h2 = new Kedi();
            h2.SesiCikar();
            Hayvan h3 = new Kopek();
            h3.SesiCikar();
            Console.ReadKey();
            //Bu kısım da dinamik polimorfizm örneğidir. Kod override edilmiştir. Çalışma zamanında gerçekleşir.
        }
    }
}
