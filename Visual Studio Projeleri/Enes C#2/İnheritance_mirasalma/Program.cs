using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance_mirasalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.hayvanisim = "Boncuk";
            kedi.hayvancinsiyet = "Dişi";
            kedi.hayvanrenk = "Beyaz";
            kedi.kedigozrengi = "Mavi";

            kedi.hayvanbilgisigöster();
            kedi.kediMetot();

            Console.ReadLine();

        }
    }
}
