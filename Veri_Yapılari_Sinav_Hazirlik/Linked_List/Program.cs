using Linked_List;
using System;
using System.Reflection;

namespace Linked_List
{
    public class Node
    {
        public string Ograd;
        public string Ogrsoyad;
        public int Ogrnumara;
        public Node next;

        public Node(string ad, string soyad, int numara)
        {
            Ograd = ad;
            Ogrsoyad = soyad;
            Ogrnumara = numara;
            this.next = null;
        }
    }

    public class LinkedList
    {
        Node head;
        Node tail;

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        //Düğüm oluşturma 

        public void enqueue(string ad, string soyad, int numara)
        {
            var newNode = new Node(ad, soyad, numara);
            if (this.tail != null)
            {
                this.tail.next = newNode;
            }
            this.tail = newNode;
            if (this.head == null)
            {
                this.head = newNode;
            }
        }

        //Düğüm silme

        public Node dequeue()
        {
            if (this.head == null) return null;
            Node gecici = this.head;
            this.head = this.head.next;
            if (this.head == null)
            {
                this.tail = null;
            }
            return gecici;
        }

        //Düğüm listeleme

        public void dugumYazdir()
        {
            var pointer = this.head;
            while (pointer != null)
            {
                Console.WriteLine($"Ad: {pointer.Ograd}, Soyad: {pointer.Ogrsoyad}, Numara: {pointer.Ogrnumara}");
                pointer = pointer.next;
            }
        }

        //Düğüm arama
        public Node arama(int numara)
        {
            var pointer = this.head;
            while (pointer != null)
            {
                if (pointer.Ogrnumara == numara)
                {
                    return pointer;
                }
                pointer = pointer.next;
            }
            return null;
        }
        
    }
}


class Program
{
    static void Main(string[] args)
    {
        var Listem = new LinkedList();
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
                    Listem.enqueue(ad, soyad, numara);
                    break;
                case 2:
                    var silinen = Listem.dequeue();
                    if (silinen != null)
                    {
                        Console.WriteLine($"Silinen Öğrenci Bilgileri: Ad: {silinen.Ograd}, Soyad: {silinen.Ogrsoyad}, Numara: {silinen.Ogrnumara}");
                    }
                    else
                    {
                        Console.WriteLine("Listeniz boştur! ");
                    }
                    break;
                case 3:
                    Listem.dugumYazdir();
                    break;
                case 4:
                    Console.WriteLine("Aramak istediğiniz öğrencinin numarasını giriniz:");
                    int ogrenciNo = int.Parse(Console.ReadLine());
                    var aranan = Listem.arama(ogrenciNo);
                    if (aranan != null)
                    {
                        Console.WriteLine($"Ad: {aranan.Ograd}, Soyad: {aranan.Ogrsoyad}, Numara: {aranan.Ogrnumara}");
                    }
                    else
                    {
                        Console.WriteLine("Aranan öğrenci bulunamadı! ");
                    }
                    break;
                case 5:
                    Console.WriteLine("Sistemden çıkılıyor...");
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyiniz: ");
                    break;
            }
        }
        while (secim != 5);

    }
}

