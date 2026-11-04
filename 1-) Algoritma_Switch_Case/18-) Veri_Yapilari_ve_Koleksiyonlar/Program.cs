using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Veri_Yapilari_ve_Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList object tipi ile çalıştığı için ve boxing (int - object) ve unboxing (object - int) yapıldığı için verinin tip güvenliği sağlanamamaktadır.
            //Fakat list<T> buradaki T kısmındaki yapı generic bir yapı olduğundan ötürü içeri hangi veri tipi verilir ise onu kullanmamızı sağlamaktadır.
            //Bu da bize tip güvenliği sağlamaktadır. Boxing ve unboxing yapmaya gerek yoktur. Ve ArrayList ungeneric bir liste tipidir.
            //Hashtable yapısında da tip güvenliğini kaybedeceğiz. Object old. için ve boxing ve unboxing işlemleri yine yapılacak. Zaten bundan dolayı tip güvenliğimizi kaybetmekteyiz.
            //SortedList de ungeneric bir yapıdır ve tip güvenliğini koruyamayacağız.
            //Artık veri yapıları temellerine başlıyoruz. Kılıcımız keskin olsun :).





        }



    }
}
