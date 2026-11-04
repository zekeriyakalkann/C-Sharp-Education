using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet_Abi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 3, 4, 5, };
            int gecici;

            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 0; j < dizi.Length-1; j++) //
                {
                    if (dizi[j] < dizi[j + 1])
                    {
                        gecici = dizi[j];
                        dizi[j] = dizi[j + 1];
                        dizi[j + 1] = gecici;   //Burada elemanların yerini değiştirmemize yaramaktadır.
                    }
                }
            }
        }
    }
}
