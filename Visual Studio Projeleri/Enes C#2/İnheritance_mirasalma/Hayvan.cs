using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance_mirasalma
{
    public class Hayvan
    {
        public string hayvanisim;
        public string hayvancinsiyet;
        public string hayvanrenk;
        private int hayvanyas;

        public void hayvanbilgisigöster()
        {
            Console.WriteLine("Hayvan ismi :" + hayvanisim);
            Console.WriteLine("Hayvan cinsiyeti :" + hayvancinsiyet);
            Console.WriteLine("Hayvan rengi : " + hayvanrenk);

        }
    }
}
