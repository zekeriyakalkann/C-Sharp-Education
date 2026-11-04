using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_While_Ornek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının tahmin etmesini
            //isteyecek bir while döngüsü yazalım.
             
            int SistemUretSayi = 0;
            Random rnd = new Random();
            SistemUretSayi = rnd.Next(1,10);
            int haksayisi = 3;
            Console.WriteLine("Sistemin 1 ile 10 arasındaki tuttuğu sayıyı tahmin ediniz: ");
            Console.WriteLine("Sadece 3 hakkınız var. Haklarınızı lütfen dikkatli kullanınız...");

            while (true)
            {
                int TahminGiris = Convert.ToInt32(Console.ReadLine());

                if (TahminGiris>0 && TahminGiris <=10 && haksayisi>=1)
                {
                    if (TahminGiris == SistemUretSayi )
                    {
                        Console.WriteLine("Tebrikler. Doğru şekilde değeri tahmin ettiniz...");
                    }
                    else
                    {
                        Console.WriteLine("Yanlış değer girdiniz. Lütfen tekrar deneyiniz: ");
                        haksayisi--;
                    }
                }
                else if (TahminGiris <=0 &&  TahminGiris >10 && haksayisi >= 1)
                {
                    Console.WriteLine("Belirlenen değer aralığından farklı bir değer girdiniz. Lütfen tekrar deneyiniz: ");
                    haksayisi--;
                }
                else
                {
                    Console.WriteLine("Hakkınız dolmuştur. Değeri doğru tahmin edemediniz...");
                }
            }
            
            
        }
    }
}
