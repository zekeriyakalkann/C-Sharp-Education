using System;

public class Stack
{
    private int maxSize;    // Stack'in maksimum boyutu
    private int top;        // Stack'in tepesindeki elemanın indeksi
    private string[] isimler;    // Öğrenci adlarını tutan dizi
    private int[] numaralar;    // Öğrenci numaralarını tutan dizi

    // Yapıcı metod
    public Stack(int size)
    {
        maxSize = size;
        isimler = new string[maxSize];
        numaralar = new int[maxSize];
        top = -1;  // Başlangıçta stack boş, bu yüzden top -1
    }

    // Stack'e eleman ekleme (push)
    public void Push(string isim, int numara)
    {
        if (top == maxSize - 1)
        {
            Console.WriteLine("Stack dolu. Eleman eklenemiyor.");
            return;
        }
        top++;
        isimler[top] = isim;
        numaralar[top] = numara;
    }

    // Stack'ten eleman silme (pop)
    public void Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack boş. Eleman silinemiyor.");
            return;
        }
        Console.WriteLine($"Silinen: İsim: {isimler[top]}, Numara: {numaralar[top]}");
        top--;
    }

    // Stack'te arama yapma
    public void Search(int numara)
    {
        for (int i = 0; i <= top; i++)
        {
            if (numaralar[i] == numara)
            {
                Console.WriteLine($"Bulunan: İsim: {isimler[i]}, Numara: {numaralar[i]}");
                return;
            }
        }
        Console.WriteLine("Öğrenci bulunamadı.");
    }

    // Stack'in tüm verilerini listeleme
    public void PrintStack()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack boş.");
            return;
        }
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine($"İsim: {isimler[i]}, Numara: {numaralar[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack(100);  // Maksimum 100 elemanlı stack

        int secim;
        do
        {
            Console.WriteLine("1. Stack'e Ekle");
            Console.WriteLine("2. Stack'ten Sil");
            Console.WriteLine("3. Stack'te Ara");
            Console.WriteLine("4. Stack'i Listele");
            Console.WriteLine("5. Çıkış");
            Console.Write("Seçiminiz: ");
            secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.Write("Öğrenci Adı: ");
                    string ad = Console.ReadLine();
                    Console.Write("Öğrenci Numarası: ");
                    int numara = int.Parse(Console.ReadLine());
                    stack.Push(ad, numara);
                    break;
                case 2:
                    stack.Pop();
                    break;
                case 3:
                    Console.Write("Aranacak Öğrenci Numarası: ");
                    int arananNumara = int.Parse(Console.ReadLine());
                    stack.Search(arananNumara);
                    break;
                case 4:
                    stack.PrintStack();
                    break;
                case 5:
                    Console.WriteLine("Programdan çıkılıyor.");
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        } while (secim != 5);
    }
}

