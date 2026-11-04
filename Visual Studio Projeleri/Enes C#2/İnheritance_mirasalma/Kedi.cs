using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance_mirasalma
{
    public class Kedi : Hayvan                     //Kedi classsının hayvan classını miras alabilmesi için ":" kullanılır.
    {
        //Buraya hiçbir şey yazmıyorum...


        public string kedigozrengi;             //Ama bir şeyler de tanımlanabilmektedir.
        public void kediMetot()
        {
            Console.WriteLine("Kedi Miyavlıyor...");
        }
    }
}
