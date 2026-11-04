using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _52__Diziler_Ornek_Cozumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Int veri tipinde bir dizi oluşturalım. Kullanıcımız bize dizinin kaç elemanlı olacağını söylesin. Ve dizi içindeki
            //alanlara atamalarını yapsın. Daha sonra dizi içerisindeki elemanlarının toplamlarını ve ortalamasını bulan 
            //kodu C# dilinde yazalım.

            Console.WriteLine("Lütfen oluşturmak istediğiniz veri tipinin uzunluğunun girişini yapınız: ");

            int diziUzunluk = int.Parse(Console.ReadLine());

            int[] diziInt = new int[diziUzunluk];

            for (int diziIndex = 0; diziIndex < diziInt.Length; diziIndex++)
            {
                Console.WriteLine("Lütfen {0}. index değerini giriniz: ", diziIndex);
                diziInt[diziIndex] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tebrikler. Dizi elamlarının veri girişlerini gerçekleştirdiniz...");
            Console.WriteLine("Dizilerin değerleri, toplam ve ortalaması aşağıdaki gibidir: ");


            int toplam = 0;
            int ortalama = 0;

            foreach (int i in diziInt)
            {
                Console.WriteLine(i);
                toplam = toplam + i;
            }
            Console.WriteLine("***********************");

            Console.WriteLine("Dizinin elemanalarının toplamı: {0}", toplam);

            ortalama = toplam / diziInt.Length;
            Console.WriteLine("Dizinin ortalaması: {0}", ortalama);
            Console.ReadLine();

            //Bu şekildedir...

            //Örnek 2: 

            //20 elemanlı bir int dizi oluştur. Değerlerimizi random sınıfı next fonksiyonu ile 1 ile 10 arasında değerler
            //ile dolduralım. Daha sonra dizi içerisindeki elemanları ekrana yazdıralım ve ilgili dizi içerisinde kaç adet
            //4 olduğunu bulan C# kodunu yazalım....

            //Random Rnd = new Random();

            //int[] sayilar = new int[20];

            //for (int sayac = 0; sayac < sayilar.Length; sayac++)
            //{
            //    sayilar[sayac] = Rnd.Next(1,10);
            //}

            //int sayac4icin = 0;

            //foreach (int i in sayilar) 
            //{
            //    Console.WriteLine(i);
            //    if (i == 4)
            //    {
            //        sayac4icin++;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}

            //Console.WriteLine("Dizi içerisindeki \"4\" değerinin sayısı: {0}",sayac4icin);
            //Console.ReadLine();

            //Bu örnek de bu şekildedir...





        }
    }
}
