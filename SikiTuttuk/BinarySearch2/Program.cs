using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch2
{
    public class Binary
    {
        public int İkiliSiralama(int[] dizi, int hedef)
        {
            int baslangic = 0;
            int bitis = dizi.Length - 1;

            while (baslangic <= bitis) 
            {
                int orta = (baslangic + bitis) / 2;

                if (dizi[orta] == hedef)
                {
                    return orta;
                }

                else if (dizi[orta] < hedef)
                {
                    baslangic = orta + 1;
                }
                else
                {
                    bitis = orta - 1;
                }
            }
            return -1;
        }
        
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Binary B1 = new Binary();

            int[] siralama = {1, 2, 3, 4, 5, 6, 7};



            int hedef = 5;

            int sonuc = B1.İkiliSiralama(siralama, hedef);
            

            //Bubble sort 

            if (sonuc != -1)
            {
                Console.WriteLine($"Aranan {hedef} değeri, {sonuc}. indexte bulundu.");
            }
            else
            {
                Console.WriteLine($"Aranan {hedef} değeri bulunamadı.");
            }

            Console.ReadKey();
        }
    }
}
