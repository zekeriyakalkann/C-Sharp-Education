using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_OPERATOR_Alistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan gelen 3 farklı sınav notunun ortalaması 45 değerine eişt veya büyük mü kontrol edelim...

            Console.Write("1. Sınav notunu giriniz:  ");
            int not1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sınav notunu giriniz:  ");
            int not2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. Sınav notunu giriniz:  ");
            int not3 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            
            int notOrtalama = (not1 + not2 + not3)/ 3;
            bool KontrolEt = notOrtalama >= 45;


            Console.WriteLine(KontrolEt);
            Console.ReadLine();
            






        }
    }
}
