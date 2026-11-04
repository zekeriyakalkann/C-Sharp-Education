using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Byte_ve_Int_VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INT ve byte da tam sayıları saklamaktayız. 
            //İkisi arasındaki fark int daha fazla değer saklayabilirken byte daha az veri içinde saklayabilir.

            byte deger1 = 10;
            int deger2 = 13;
            Console.WriteLine(deger1+deger2);
            Console.ReadLine();

            //Burada matematiksel işlemler yapılabilir. String içine yazılan şeylerde işlem yapamayız. 

            //Byte ve int in en  küçük ve en büyük değerlerini görebilmek için aşağıdakileri yapmalıyız:

            byte minvalue = byte.MinValue;
            byte maxvalue = byte.MaxValue;
            int minvalue2 = int.MinValue; 
            int maxvalue2 = int.MaxValue;

            //Şeklinde yapılmaktadır. Bu sayede bu veri tiplerinin ne aralıklarda değer aldığını görebiliriz.


        }
    }
}
