using System;

class SelectionSort
{
    static void Main(string[] args)
    {
        // Dizi oluşturma
        int[] dizi = { 64, 25, 12, 22, 11 };

        // Sıralanmamış diziyi ekrana yazdırma
        Console.WriteLine("Dizinin sıralanmamış hali:");
        DiziYazdir(dizi);

        // Selection Sort algoritması ile diziyi sıralama
        SelectionSortAlgoritma(dizi);

        // Sıralanmış diziyi ekrana yazdırma
        Console.WriteLine("\nDizinin sıralanmış hali:");
        DiziYazdir(dizi);
        Console.ReadKey();
    }

    // Selection Sort algoritması
    
    
    //int[] dizi = { 64, 25, 12, 22, 11 };
    static void SelectionSortAlgoritma(int[] dizi)
    {
        int n = dizi.Length;

        // Dizinin tüm elemanları için döngü
        for (int i = 0; i < n - 1; i++)
        {
            // Minimum elemanın index'ini tutan değişken
            int minIndex = i;

            // Dizinin kalan kısmı üzerinde döngü
            for (int j = i + 1; j < n; j++)
            {
                // Minimum elemanı bulma
                if (dizi[j] < dizi[minIndex])
                {
                    minIndex = j;
                }
            }

            // Bulunan minimum elemanı başlangıçtaki eleman ile değiştirme
            int temp = dizi[minIndex];
            dizi[minIndex] = dizi[i];
            dizi[i] = temp;
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

