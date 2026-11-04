using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Zamansal_Degisken_Tipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Kullanıcı saat 13 - 17
            //2. Kullanıcı saat 17 - 22

            //1. kullanıcı kartı okut
            //kartın içerisinde bulunan id : 1 
            //1. Kullanıcının geldiği saat 14 = true dönecektir.
            //2. kullanıcının geldiği saat 14 = false dönecektir.

            //Bu gibi durumların kontrolünü biz DateTime ile beraber yapmaktayız.

            DateTime Simdikizaman = DateTime.Now;
            Console.WriteLine(Simdikizaman);
            Console.ReadLine();


        }
    }
}
