using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SikiTuttuk
{
    public class BinarySearch
    {
      public int İkiliSiralama(int[] dizi, int hedef)
        {
            int baslangic = 0;
            int bitis = dizi.Length-1;

            while(baslangic <= bitis)
            {
                int orta = (bitis + baslangic)/2;
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
}
