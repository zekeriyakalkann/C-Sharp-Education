using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Veri_Turleri_Alt_Ust_Limit_Hesabi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 bit integer signed yani işaretli olan

            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt limit       : {SByte.MinValue,20}");   //$ ifadesi string iç içe yerleştirme olarak geçer ve "" arasına da kod yazabilme kolaylığını bize sağlamaktadır.
            Console.WriteLine($"Üst limit       : {SByte.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(SByte),20}");
            Console.WriteLine();
            Console.ReadKey();  //Bu şekilde yaptığımız zaman bir tuşa dokunduğumuzda bir alttaki kodları çalıştırır. Yani program kapanmaz.

            //Unsigned yani işaretli olmayan 8 bit  integer

            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt limit       : {Byte.MinValue,20}");   
            Console.WriteLine($"Üst limit       : {Byte.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(Byte),20}");  //Boyut 1 gelir yani 1 byte = 8 bit anlamına gelmektedir.
            Console.WriteLine();
            Console.ReadKey();

            //signed yani işaretli olan 16 bit  integer

            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt limit       : {Int16.MinValue,20}");
            Console.WriteLine($"Üst limit       : {Int16.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(Int16),20}");  
            Console.WriteLine();
            Console.ReadKey();

            //Unsigned yani işaretli olmayan 16 bit  integer

            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt limit       : {UInt16.MinValue,20}");
            Console.WriteLine($"Üst limit       : {UInt16.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(UInt16),20}");
            Console.WriteLine();
            Console.ReadKey();

            //signed yani işaretli olan 32 bit  integer

            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt limit       : {Int32.MinValue,20}");
            Console.WriteLine($"Üst limit       : {Int32.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(Int32),20}");
            Console.WriteLine();
            Console.ReadKey();

            //Unsigned yani işaretli olmayan 32 bit  integer

            Console.WriteLine(nameof(UInt32));
            Console.WriteLine($"Alt limit       : {UInt32.MinValue,20}");
            Console.WriteLine($"Üst limit       : {UInt32.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(UInt32),20}");
            Console.WriteLine();
            Console.ReadKey();

            //Double ...

            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Alt limit       : {Double.MinValue,20}");
            Console.WriteLine($"Üst limit       : {Double.MaxValue,20}");
            Console.WriteLine($"Boyut           : {sizeof(Double),20}");
            Console.WriteLine();
            Console.ReadKey();


            //Bu şekilde alt ve üst limitleri ve boyutları görebilmemiz mümkün olmaktadır. Başka merak edilen örneklere de bu şekilde inceleyerek bakabiliriz.
            Console.ReadKey();
        }
    }
}

            //C# dilinde $ işareti "string interpolation" veya "string iç içe yerleştirme" için kullanılır. Bu özellik, bir string ifadesinin
            //içine doğrudan değişken veya ifade eklememize olanak tanır. $ işareti, bir string ifadesinin başında kullanıldığında o ifadenin içinde
            //{} süslü parantezler içine yazılan değişken veya ifadeler otomatik olarak değerlendirip stringe dönüştürülerek ilgili yere yerleştirilir.