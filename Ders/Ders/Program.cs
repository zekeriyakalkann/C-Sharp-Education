using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders
{
    internal class Program
    {
        List<Class1> list = new List<Class1>();
        static void Main(string[] args)
        {
            Program p1 = new Program();

            Class1 K1 = new Class1("etek" , 50);

            p1.list.Add(K1);

            Class1 K2 = new Class1("gömlek", 75);

            p1.list.Add(K2);

            Class1 K3 = new Class1("cüzdan", 100);

            p1.list.Add(K3);

            Class1 K4 = new Class1("çanta", 150);

            p1.list.Add(K4);

            Class1 K5 = new Class1("kaban", 200);

            p1.list.Add(K5);









        }
    }
}
