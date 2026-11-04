using System;

public class Node
{
    public string OgrenciAdi;
    public string OgrenciSoyadi;
    public int OgrenciNumarasi;
    public Node Next;

    // Yapıcı metod
    public Node(string ad, string soyad, int numara)
    {
        this.OgrenciAdi = ad;
        this.OgrenciSoyadi = soyad;
        this.OgrenciNumarasi = numara;
        this.Next = null;
    }
}

public class LinkedList
{
    private Node head;
    private Node tail;

    // Bağlı liste oluşturucu
    public LinkedList()
    {
        this.head = null;
        this.tail = null;
    }

    // Düğüm ekleme işlemi (enqueue)
    public void Enqueue(string ad, string soyad, int numara)
    {
        var newNode = new Node(ad, soyad, numara);
        if (this.tail != null)
        {
            this.tail.Next = newNode;
        }
        this.tail = newNode;
        if (this.head == null)
        {
            this.head = newNode;
        }
    }

    // Düğüm silme işlemi (dequeue)
    public Node Dequeue()
    {
        if (this.head == null) return null;
        Node temp = this.head;
        this.head = this.head.Next;
        if (this.head == null)
        {
            this.tail = null;
        }
        return temp;
    }

    // Düğüm listeleme işlemi
    public void PrintList()
    {
        Node pointer = this.head;
        while (pointer != null)
        {
            Console.WriteLine($"Ad: {pointer.OgrenciAdi}, Soyad: {pointer.OgrenciSoyadi}, Numara: {pointer.OgrenciNumarasi}");
            pointer = pointer.Next;
        }
    }

    // Düğüm arama işlemi
    public Node Search(int numara)
    {
        Node pointer = this.head;
        while (pointer != null)
        {
            if (pointer.OgrenciNumarasi == numara)
            {
                return pointer;
            }
            pointer = pointer.Next;
        }
        return null;
    }
}

class Program
{
    static void Main(string[] args)
        {
        LinkedList list = new LinkedList();
        int secim;
        do
        {
            Console.WriteLine("1. Düğüm Ekle");
            Console.WriteLine("2. Düğüm Sil");
            Console.WriteLine("3. Düğüm Listele");
            Console.WriteLine("4. Düğüm Ara");
            Console.WriteLine("5. Çıkış");
            Console.Write("Seçiminiz: ");
            secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.Write("Öğrenci Adı: ");
                    string ad = Console.ReadLine();
                    Console.Write("Öğrenci Soyadı: ");
                    string soyad = Console.ReadLine();
                    Console.Write("Öğrenci Numarası: ");
                    int numara = int.Parse(Console.ReadLine());
                    list.Enqueue(ad, soyad, numara);
                    break;
                case 2:
                    Node silinen = list.Dequeue();
                    if (silinen != null)
                    {
                        Console.WriteLine($"Silinen Öğrenci: Ad: {silinen.OgrenciAdi}, Soyad: {silinen.OgrenciSoyadi}, Numara: {silinen.OgrenciNumarasi}");
                    }
                    else
                    {
                        Console.WriteLine("Liste boş.");
                    }
                    break;
                case 3:
                    list.PrintList();
                    break;
                case 4:
                    Console.Write("Aranacak Öğrenci Numarası: ");
                    int arananNumara = int.Parse(Console.ReadLine());
                    Node bulunan = list.Search(arananNumara);
                    if (bulunan != null)
                    {
                        Console.WriteLine($"Bulunan Öğrenci: Ad: {bulunan.OgrenciAdi}, Soyad: {bulunan.OgrenciSoyadi}, Numara: {bulunan.OgrenciNumarasi}");
                    }
                    else
                    {
                        Console.WriteLine("Öğrenci bulunamadı.");
                    }
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

