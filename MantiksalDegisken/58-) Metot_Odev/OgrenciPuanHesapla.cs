using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58___Metot_Odev
{
    public class OgrenciPuanHesapla
    {
        public void OgrenciPuanHesaplama(string adSoyad, decimal not1, decimal not2, decimal not3)
        {

            Console.WriteLine("Öğrencinin adı ve soyadı: {0}",adSoyad);


            Console.WriteLine("Öğrencinin birinci, ikinci ve üçüncü notu: {0}, {1}, {2}",not1,not2,not3);

            decimal sonuc = (not1 + not2 + not3) / 3;

            Console.WriteLine("Öğrencinin bu üç notunun ortalaması: {0}",sonuc);

            if (sonuc < 50) 
            {
                Console.WriteLine("Öğrenci dersten kalmıştır.");
            }

            else if (sonuc >= 50 )
            {
                Console.WriteLine("Tebrikler. Dersten başarılı bir şekilde geçtiniz.");
            }


        }
    }
}
