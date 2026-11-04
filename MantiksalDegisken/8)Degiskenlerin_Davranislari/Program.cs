using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Degiskenlerin_Davranislari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken1 = "Zekeriya KALKAN";
            string degisken2 = "Sedanur SOLMAZ";

            degisken1 = degisken2;

            degisken2 = "Gamze MASTARCIOĞLU";
            //Değişken 2 önce değişken 1 e eşitlendi, daha sonra ise Değişken 2 tekrardan değiştirildi. Davranışları temel hali
            //ile bu şekilde olmaktadır.

        }
    }
}
