using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SİNAV_SORULARİ_2
{
    //Bir tamsayı dizisini parametre olarak alıp ortalamasını geri döndüren fonksiyonu yazınız.
    public class program
    {
        //Bir tamsayı dizisini parametre olarak alıp ortalamasını geri döndüren fonksiyonu yazınız.
        static void Main()
        {
            int[] dizi = diziOlustur();
            diziYazdir(dizi);
            Console.WriteLine();
            diziOrtalama(dizi);
            Console.ReadKey();
        }
        static int[] diziOlustur()
        {
            Console.WriteLine("Lütfen oluşturmak istediğiniz dizinin uzunluğunu giriniz: ");
            int diziuzunluk = int.Parse(Console.ReadLine());
            int[] dizi = new int[diziuzunluk];

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("Dizinin {0}. elemanını giriniz: ", i + 1);
                dizi[i] = int.Parse(Console.ReadLine());
            }
            return dizi;
        }

        static void diziYazdir(int[] dizi)
        {
            Console.WriteLine("Dizinin elemanları: ");
            foreach (int i in dizi)
            {
                Console.Write(i + " ");
            }
        }

        static void diziOrtalama(int[] dizi)
        {
            int toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam += toplam + dizi[i];
            }
            Console.WriteLine("Dizinin ortalaması: ");
            Console.WriteLine(toplam / dizi.Length);
        }


    }
}
