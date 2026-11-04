using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Cevirmeler_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)  //While iken anlamına gelmektedir.
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Döngü sonu!");
            Console.ReadKey();
        }
    }
}
