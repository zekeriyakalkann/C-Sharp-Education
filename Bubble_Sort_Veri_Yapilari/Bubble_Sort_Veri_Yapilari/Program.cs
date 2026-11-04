using System;

class KabarcikSiralamaOrnek
{
    static void BubbleSort(int[] dizi)
    {
        int n = dizi.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (dizi[j] > dizi[j + 1])
                {
                    // Elemanları yer değiştir
                    int gecici = dizi[j];
                    dizi[j] = dizi[j + 1];
                    dizi[j + 1] = gecici;
                }
            }
        }
    }

    static void Main()
    {
        int[] dizi = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Sıralanmamış dizi:");
        DiziYazdir(dizi);

        BubbleSort(dizi);

        Console.WriteLine("Sıralanmış dizi:");
        DiziYazdir(dizi);
    }

    static void DiziYazdir(int[] dizi)
    {
        foreach (int eleman in dizi)
        {
            Console.Write(eleman + " ");
        }
        Console.WriteLine();
    }
}
