using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisimmetotpratik
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Öğrenci ogrencibilgi = new Öğrenci(349, "Zekeriya", "Kalkan", 25, 35, 85, "Bitlis Eren Üniversitesi" );

            Console.WriteLine("Öğrenci uygulamamıza hoşgeldiniz. Yapmak istediğiniz işlemi lütfen seçiniz: ");

            işlemlerigöster();      //Direk bu şekilde kodumuzun eğer kaba gözükmesini istemiyorsak kullanım yapabiliriz.

            
            while (kontrol)
            {

                string secim = Console.ReadLine();


                switch (secim)
            {
                case "1":
                        ogrencibilgi.ogrencibilgilerinigoster();    //Burası void tipinde olduğundan geri dönme yapmaz. Bu yüzden aşağıdaki gibi bir tanımlama yapmaya gerek yoktur.
                    break;
                
                case "2":
                   double ortalama =  ogrencibilgi.ogrencinotubul(); //Burada ise dönme işlemi olduğunda double ile tanımlamamız gerekmektedir.
                    Console.WriteLine("Öğrencinin notu : " + ortalama);
                    break; 
                
                case "3":
                    ogrencibilgi.ogrencigetir();
                    break;
                
                case "4":
                        kontrol = false; 
                        break;
            }
          }
        }


        static void işlemlerigöster()
        {
            Console.WriteLine("1-) Öğrenci bilgilerini göster: ");
            Console.WriteLine("2-) Öğrencinin ortalamasını göster: ");
            Console.WriteLine("3-) Öğrencinin okulunu göster: ");
            Console.WriteLine("4-) Çıkış yap");
            

        }
    }
}
