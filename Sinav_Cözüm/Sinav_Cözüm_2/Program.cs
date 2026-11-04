using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav_Cözüm_2
{
    internal class Program
    {
        List<Tatil> list = new List<Tatil>()
        {
            new Tatil("Roma", 4, 1200),
            new Tatil("Paris", 5, 1500),
            new Tatil("Berlin", 6, 1800),
            new Tatil("Amsterdam", 4, 1600)
        };
        static void Main(string[] args)
        {
            Program pr = new Program();
            Tatil gecici;
            for (int i = 0; i < pr.list.Count; i++)
            {
                for (int j = 0; j < pr.list.Count - 1 - i; j++)
                {
                    if (string.Compare(pr.list[j].Adi, pr.list[j + 1].Adi) > -1)
                    {
                        gecici = pr.list[j];
                        pr.list[j] = pr.list[j + 1];
                        pr.list[j + 1] = gecici;
                    }
                }
            }

            for (int i = 0; i < pr.list.Count; i++)
            {
                for (int j = 0; j < pr.list.Count - 1 - i; j++)
                {
                    if (string.Compare(pr.list[j].Adi, pr.list[j + 1].Adi) == 0 && pr.list[j].SayfaSayisi > pr.list[j + 1].SayfaSayisi)
                    {
                        gecici = pr.list[j];
                        pr.list[j] = pr.list[j + 1];
                        pr.list[j + 1] = gecici;
                    }
                }
            }

        }
    }
}
