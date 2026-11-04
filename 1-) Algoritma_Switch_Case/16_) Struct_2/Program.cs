using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _16___Struct_2
{
    public struct Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()   //Varsayılan ToString metodu nesnenin türünü döndürür, fakat bu yöntemi ezerek istediğimiz string ifadesini döndürebiliriz. Yani aslında tostring metodunu override ederek geçersiz kılıp istediğimiz string değerlerinin ekranda görünmesini sağlamış olduk.
        {
            return $"{X},{Y}";
        }

        //Default constructor adını veririz.
        public Nokta(int x, int y)
        {
            X = x ; 
            Y = y ;
        }

        //Yapımıza yeni üye -> Metot.

        public void SetOrigin()
        {
            this.X = 0 ;    //Burada this kullanımına gerek olmadığını bize vurguluyor. Soluk renkli olduğu için.
            this.Y = 0 ;
        }

        public void Degistir()
        {
            var gecici = X;
            X = Y;
            Y = gecici;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Struct -> değer tipli
            var n1 = new Nokta(3,4);
            Console.WriteLine($"n1: {n1}");

            n1.Degistir();
            Console.WriteLine($"n1: {n1}"); ;

            var n2 = n1;

            Console.WriteLine($"n2: {n2}");

            n2.X = -1 * n2.X;

            Console.WriteLine($"n1: {n1}");
            Console.WriteLine($"n2: {n2}");

            //Aslında bu örnekler ile struct yapısının değer tipli değişkenlerde kullanılması gerektiğini anlatmaktayız.

            Console.ReadKey();
        }
    }
}
