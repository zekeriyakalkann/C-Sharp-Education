using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Ozel_OPERATÖRLER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mod alma (%) operatörü :
            int s1 = 10;
            int s2 = 2;
            int modsonuc = s1%s2;   //Kalanı bulmamıza yarar mod dediğimiz şey 

            // ++ operatörü :

            int s3 = 10;
            int OperatorSonuc1 = s3++;      //Önce atama işlemini yapar sonra toplar. 
            int OperatorSonuc2 = ++s3;      //Önce değerleri toplar sonra atama işlemini yapar.

            // -- operatörü :

            int s4 = 10;
            int OperatorSonuc3 = s4--;
            int OperatorSonuc4 = --s4;      //++ operatörü ile aynı işlevi görür.



        }
    }
}
