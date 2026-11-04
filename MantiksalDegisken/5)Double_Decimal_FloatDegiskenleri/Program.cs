using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Double_Decimal_FloatDegiskenleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Double : Küsüratlı değerlerli saklamaya yaramaktadır.

            double doubleval = 10.2;
            double doubleval2 = 10;
            double doubleval3 = 10.9d;      //buradaki d yi koymamızın sebebi double olduğunu belirtmek içindir.
            //Double da bu d zorunlu değl

            double dobminval = double.MinValue;
            double dobmaxval = double.MaxValue;

            //float : Küsüratlı değerleri saklamaya yaramaktadır. Bu double dan daha az değer saklamaktadır.
            
            float floatval = 10.2f;     //Burada sonuna f şeklinde yazarak float olduğunu belirtmemiz gerekmektedir.

            //Decimal : En fazla küsüratlı değeri saklayabilen veri tipi olarak adlandırılmaktadır.

            decimal decvalue = 10.2M;   //Burada da M ile yine decimal olduğunu belirtmek zorundayız.

            //Bunlardan hangisini kullanacağımız biraz da gereksinimlere bağlıdır...




        }
    }
}
