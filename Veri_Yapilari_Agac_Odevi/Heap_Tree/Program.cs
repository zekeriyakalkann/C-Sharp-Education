using System;
using System.Collections.Generic;

class MaxHeap
{
    private List<int> heap = new List<int>();

    // Heap'e yeni bir eleman ekleme
    public void Insert(int element)
    {
        heap.Add(element);
        int currentIndex = heap.Count - 1;

        // Elemanı doğru konuma getirmek için yukarı taşı
        while (currentIndex > 0)
        {
            int parentIndex = (currentIndex - 1) / 2;
            if (heap[currentIndex] <= heap[parentIndex])
            {
                break;
            }

            // Elemanı yukarı taşıma
            int temp = heap[currentIndex];
            heap[currentIndex] = heap[parentIndex];
            heap[parentIndex] = temp;

            currentIndex = parentIndex;
        }
    }

    // Heap'in kök elemanını (en büyük elemanı) çıkarma
    public int ExtractMax()
    {
        if (heap.Count == 0)
        {
            throw new InvalidOperationException("Heap is empty");
        }

        int max = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);

        // Elemanı doğru konuma getirmek için aşağı taşı
        int currentIndex = 0;
        while (currentIndex < heap.Count)
        {
            int leftChildIndex = 2 * currentIndex + 1;
            int rightChildIndex = 2 * currentIndex + 2;

            if (leftChildIndex >= heap.Count)
            {
                break;
            }

            int largestChildIndex = leftChildIndex;
            if (rightChildIndex < heap.Count && heap[rightChildIndex] > heap[leftChildIndex])
            {
                largestChildIndex = rightChildIndex;
            }

            if (heap[currentIndex] >= heap[largestChildIndex])
            {
                break;
            }

            // Elemanı aşağı taşıma
            int temp = heap[currentIndex];
            heap[currentIndex] = heap[largestChildIndex];
            heap[largestChildIndex] = temp;

            currentIndex = largestChildIndex;
        }

        return max;
    }

    // Heap'i yazdırma
    public void PrintHeap()
    {
        foreach (int element in heap)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        MaxHeap maxHeap = new MaxHeap();

        // Kullanıcıdan değerleri alma
        Console.WriteLine("Lütfen heap için değerleri girin, her bir değeri bir boşlukla ayırarak girin:");
        string[] input = Console.ReadLine().Split(' ');

        foreach (string value in input)
        {
            maxHeap.Insert(int.Parse(value));
        }

        // Heap'i yazdırma
        Console.WriteLine("Heap:");
        maxHeap.PrintHeap();

        // Max değerini çıkarma ve yazdırma
        Console.WriteLine("Heap'in kök elemanı çıkarıldı: " + maxHeap.ExtractMax());

        // Heap'i yeniden yazdırma
        Console.WriteLine("Heap (yeniden düzenlenmiş):");
        maxHeap.PrintHeap();
        Console.ReadKey();
    }
}
