using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61___Parametreler
{
    internal class Program
    {
        public void yazdir(string helloword)
        {
            Console.WriteLine(helloword);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();

            string helloword = "Merhaba dünya";
            p1.yazdir(helloword);
            Console.ReadKey();

            //Bu şekilde metodumuza parametreler vererek uygulamalarımızı daha dinamik bir hale getirebilmekteyiz.



        }
    }
}
