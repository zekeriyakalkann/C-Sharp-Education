using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_For_ile_Sonsuz_Dongu_Break_ve_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sonsuz döngü nasıl oluşturulur ? Bakalım 

            int sayac = 0;

            for(; ; )       //Burada koyduğumuz iki noktalı virgül bizim sonsuz döngü oluşturmamıza yaramaktadır. 
            {
                
                //Break anahtar kelimesi;
                sayac++;
                if (sayac==2)
                {
                    //break;      //For içindeki şart ne olursa olsun if içindeki ifade true döndüğü zaman kodu kırar ve altındakileri çalıştırmadan for döngüsünü sonlandırır.

                    continue;   //Burada da sayac değişkeni 2 olduğunda atlayacaktır direkt. Kodu sonlandırmadan bu işlemi gerçekleştirir.
                }


                Console.WriteLine(sayac);

                //Continue anahtar kelimesi;

                Console.WriteLine("Gamze MASTARCIOĞLU.");

            }
            
            //for döngüsünde sonsuz bir döngü oluşturmak istersek for(; ;){  }  bu şekilde 2 adet noktalı virgül 
            //koyulur ise döngü break anahtar kelimesi yardımı ile kırılmaz ise sonsuza kadar dönmeye devam edecektir.
        }
    }
}
