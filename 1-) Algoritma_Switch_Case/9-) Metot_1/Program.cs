using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Metot_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int buyuk = Karsilastir(3,5);
            Console.WriteLine(buyuk);
            Console.ReadKey();

        }

        public static int Karsilastir(int A, int B)
        {
            return A > B ? A : B;   //Bu şekilde A ve B nin durumları karşılaştırılır ve hangisi büyük ise ekranda o yazar. Bu yine dinamik bir kod örneğidir.
        }

    }
}
