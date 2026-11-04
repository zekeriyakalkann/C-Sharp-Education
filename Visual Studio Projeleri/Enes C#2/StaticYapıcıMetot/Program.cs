using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapıcıMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kullanıcı K1 = new Kullanıcı(1,"Gamze","Mastarcıoğlu");

            K1.BilgileriGoster();
            K1.zamyap(600);
            Console.ReadLine();
        }
    }
}
