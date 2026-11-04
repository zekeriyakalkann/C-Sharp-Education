using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_kapsülleme
{
    public class Personel
    {
        private string tckimlikno;
        public string TCKİMLİKNO
        {
            get
            {
                return tckimlikno.Substring(0, 5)+ "******";     //Burada substring dediğimiz şey gözükmesini istediğimiz değerleri bize göstermeye yaramaktadır.
            }

            set
            {
                bool kontrol = true;
                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayimi = char.IsNumber(value[i]); //123a23312 değerlerinin sayı mı değil mi olduğunu kontrol etmeye yarıyor.
                        if (sayimi)
                        {
                            //Yapılacak bir şey yok. For döngüsü dönmeye devam edecektir.
                        }
                        else
                        {
                            kontrol = false;
                            break;
                        }
                    }
                }

                if (kontrol)
                {
                    tckimlikno = value;
                }
                else
                {
                    Console.WriteLine("Girdiğiniz TC kimlik numarasında geçersiz karakter bulundu...");
                }
            }
        }
    }





}

