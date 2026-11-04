using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class CircularLinkedList
{
    private Node last;

    public void AddToEmpty(int data)
    {
        if (last != null) return;

        Node newNode = new Node(data);
        last = newNode;
        last.Next = last;
    }

    public void AddAtBeginning(int data)
    {
        if (last == null)
        {
            AddToEmpty(data);
            return;
        }

        Node newNode = new Node(data);
        newNode.Next = last.Next;
        last.Next = newNode;
    }

    public void AddAtEnd(int data)
    {
        if (last == null)
        {
            AddToEmpty(data);
            return;
        }

        Node newNode = new Node(data);
        newNode.Next = last.Next;
        last.Next = newNode;
        last = newNode;
    }

    public void AddAfter(int data, int afterData)
    {
        if (last == null) return;

        Node current = last.Next;
        do
        {
            if (current.Data == afterData)
            {
                Node newNode = new Node(data);
                newNode.Next = current.Next;
                current.Next = newNode;

                if (current == last) last = newNode; // If the new node is added after last
                return;
            }
            current = current.Next;
        } while (current != last.Next);
    }

    public void DeleteAtBeginning()
    {
        if (last == null) return;

        if (last.Next == last) // Only one node
        {
            last = null;
            return;
        }

        last.Next = last.Next.Next;
    }

    public void DeleteAtEnd()
    {
        if (last == null) return;

        if (last.Next == last) // Only one node
        {
            last = null;
            return;
        }

        Node current = last.Next;
        while (current.Next != last)
        {
            current = current.Next;
        }

        current.Next = last.Next;
        last = current;
    }

    public void DeleteNode(int key)
    {
        if (last == null) return;

        if (last.Next.Data == key) // If node to be deleted is the first node
        {
            DeleteAtBeginning();
            return;
        }

        Node current = last.Next;
        Node prev = null;

        do
        {
            if (current.Data == key)
            {
                if (current == last) // If node to be deleted is the last node
                {
                    DeleteAtEnd();
                    return;
                }

                prev.Next = current.Next;
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != last.Next);
    }

    public void PrintList()
    {
        if (last == null) return;

        Node current = last.Next;
        do
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        } while (current != last.Next);
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList cll = new CircularLinkedList();
        int choice, data, afterData;

        do
        {
            Console.WriteLine("\nDairesel Bağlı Liste İşlemleri:");
            Console.WriteLine("1. Baştan Ekle");
            Console.WriteLine("2. Sondan Ekle");
            Console.WriteLine("3. İstenilen Sırada Ekle");
            Console.WriteLine("4. Baştan Sil");
            Console.WriteLine("5. Sondan Sil");
            Console.WriteLine("6. İstenilen Sırada Sil");
            Console.WriteLine("7. Listeyi Yazdır");
            Console.WriteLine("0. Çıkış");
            Console.Write("Seçiminizi yapın: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Eklenecek veri: ");
                    data = int.Parse(Console.ReadLine());
                    cll.AddAtBeginning(data);
                    break;
                case 2:
                    Console.Write("Eklenecek veri: ");
                    data = int.Parse(Console.ReadLine());
                    cll.AddAtEnd(data);
                    break;
                case 3:
                    Console.Write("Eklenecek veri: ");
                    data = int.Parse(Console.ReadLine());
                    Console.Write("Sonra eklemek istediğiniz veri: ");
                    afterData = int.Parse(Console.ReadLine());
                    cll.AddAfter(data, afterData);
                    break;
                case 4:
                    cll.DeleteAtBeginning();
                    break;
                case 5:
                    cll.DeleteAtEnd();
                    break;
                case 6:
                    Console.Write("Silinecek veri: ");
                    data = int.Parse(Console.ReadLine());
                    cll.DeleteNode(data);
                    break;
                case 7:
                    Console.WriteLine("Liste: ");
                    cll.PrintList();
                    break;
                case 0:
                    Console.WriteLine("Çıkılıyor...");
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }

        } while (choice != 0);

        Console.WriteLine("Güncel Liste: ");
        cll.PrintList();
        Console.ReadKey();
    }
}


