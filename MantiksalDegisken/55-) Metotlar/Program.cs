using System;   //Bir kütüphane dosyasını uygulamamızın içerisine eklemektir. 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55___Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program P1 = new Program();
            P1.Selamla();
            Selamla2();     //Bu şekilde static ile tanımlanan bir metotta nesne oluşturmamıza gerek yoktur. 
            Console.ReadLine();


        }

        public void Selamla()       //Bu şekilde bir kullanımda nesne oluşturmamız gerekmektedir. Aynı sınıf içerisinde olsa bile
            //Void kavramı geriye değer ya da parametre döndürmeyen bir metot tanımlamamızı sağlamaktadır. Yani return kullanmamıza gerek yoktur. 
        {
            Console.WriteLine("Merhaba Dünya");
        }

        static void Selamla2()  //Bu şekilde bir kullanımda ise nesne tanımına ihtiyacımız yoktur. Direk kodumuzu hızlı bir şekilde yazıp çağırabiliriz. 
        {
            Console.WriteLine("Merhaba Dünyalarımız :) ");
        }
    }
}
