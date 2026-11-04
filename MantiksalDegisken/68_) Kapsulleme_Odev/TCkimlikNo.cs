using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67___Kapsulleme
{
    internal class TCkimlikNo
    {
        private string TCkimlikno;
        public string TCKimlikno
        {
            private get
            {
                return this.TCkimlikno;
            }

            set
            {

                if (value.Length == 11)
                {
                    bool bayrak = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool kontrolNoktasi = char.IsNumber(value[i]);

                        if (kontrolNoktasi)
                        {
                            //Sadece girilen ifadede sayısal değerler mevcut. Bundan dolayı içeriye bir şey yazmamıza gerek yoktur.
                        }

                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }

                    if (bayrak)
                    {
                        Console.WriteLine("TC kimlik numarası sayısal değerler içermelidir...");
                    }

                    else
                    {
                        this.TCkimlikno = value;
                    }
                }

                else
                {
                    Console.WriteLine("TC kimlik numarası 11 haneli olmak zorundadır...");
                }
            }
        }

    }
}

