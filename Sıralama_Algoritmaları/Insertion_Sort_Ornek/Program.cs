using System;

class InsertionSort
{
    static void Main(string[] args)
    {
        // Dizi oluşturma
        int[] dizi = { 64, 25, 12, 22, 11 };

        // Sıralanmamış diziyi ekrana yazdırma
        Console.WriteLine("Dizinin sıralanmamış hali:");
        DiziYazdir(dizi);

        // Insertion Sort algoritması ile diziyi sıralama
        InsertionSortAlgoritma(dizi);

        // Sıralanmış diziyi ekrana yazdırma
        Console.WriteLine("\nDizinin sıralanmış hali:");
        DiziYazdir(dizi);
        Console.ReadKey();
    }

    // Insertion Sort algoritması
    static void InsertionSortAlgoritma(int[] dizi)
    {
        int n = dizi.Length;

        // Dizinin tüm elemanları üzerinde döngü
        for (int i = 1; i < n; ++i)
        {
            int key = dizi[i]; // Seçilen anahtar eleman

            int j = i - 1;

            // Anahtar elemanı sıralı bölümdeki uygun konuma yerleştirme
            while (j >= 0 && dizi[j] > key)
            {
                dizi[j + 1] = dizi[j];
                j = j - 1;
            }
            dizi[j + 1] = key;
        }
    }

    // Diziyi ekrana yazdıran fonksiyon
    static void DiziYazdir(int[] dizi)
    {
        foreach (int num in dizi)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

