using System;
using System.Collections.Generic;

// Huffman ağacı düğüm sınıfı
class HuffmanNode
{
    public char Character;  // Karakteri temsil eder
    public int Frequency;   // Karakterin frekansı
    public HuffmanNode Left;   // Sol çocuk düğümü
    public HuffmanNode Right;  // Sağ çocuk düğümü

    // Düğüm oluşturucu (constructor)
    public HuffmanNode(char character, int frequency)
    {
        Character = character;
        Frequency = frequency;
        Left = Right = null;
    }
}

class CodingTree
{
    // Huffman ağacını oluşturma fonksiyonu
    public static HuffmanNode BuildHuffmanTree(Dictionary<char, int> frequencies)
    {
        List<HuffmanNode> nodes = new List<HuffmanNode>();

        // Her karakter için bir düğüm oluştur ve listeye ekle
        foreach (var symbol in frequencies)
        {
            nodes.Add(new HuffmanNode(symbol.Key, symbol.Value));
        }

        // Ağacı oluşturmak için düğümleri birleştir
        while (nodes.Count > 1)
        {
            // Frekansa göre düğümleri sırala
            nodes.Sort((x, y) => x.Frequency - y.Frequency);

            // İki en düşük frekanslı düğümü seç
            HuffmanNode left = nodes[0];
            HuffmanNode right = nodes[1];

            // Yeni bir iç düğüm oluştur (iki düğümün toplam frekansını içeren)
            HuffmanNode sum = new HuffmanNode('*', left.Frequency + right.Frequency);
            sum.Left = left;
            sum.Right = right;

            // İki düğümü listeden çıkar ve yeni düğümü ekle
            nodes.Remove(left);
            nodes.Remove(right);
            nodes.Add(sum);
        }

        // Son kalan düğüm kök düğüm olacaktır
        return nodes[0];
    }

    // Huffman kodlarını üretme fonksiyonu
    public static void GenerateCodes(HuffmanNode root, string code, Dictionary<char, string> huffmanCodes)
    {
        if (root == null) return;

        // Yaprak düğüm
        if (root.Left == null && root.Right == null)
        {
            huffmanCodes[root.Character] = code;
        }

        // Sol alt ağaca "0" ekleyerek git
        GenerateCodes(root.Left, code + "0", huffmanCodes);

        // Sağ alt ağaca "1" ekleyerek git
        GenerateCodes(root.Right, code + "1", huffmanCodes);
    }

    // Ana program
    static void Main(string[] args)
    {
        // Kullanıcıdan karakter frekanslarını alma
        Console.WriteLine("Lütfen karakterlerin ve frekanslarının aralarında boşluk bırakarak girin " +
            "(örneğin: c 32 k 14 l 3 e 9 gibi bir giriş yapınız: ):");
        string[] input = Console.ReadLine().Split(' ');

        var frequencies = new Dictionary<char, int>();

        // Kullanıcıdan alınan girdi ile frekans sözlüğünü oluştur
        for (int i = 0; i < input.Length; i += 2)
        {
            char character = input[i][0];
            int frequency = int.Parse(input[i + 1]);
            frequencies[character] = frequency;
        }

        // Huffman ağacını oluştur
        var root = BuildHuffmanTree(frequencies);

        // Huffman kodlarını üret
        var huffmanCodes = new Dictionary<char, string>();
        GenerateCodes(root, "", huffmanCodes);

        // Huffman kodlarını yazdıracak olan yapı
        Console.WriteLine("Huffman Kodları:");
        foreach (var code in huffmanCodes)
        {
            Console.WriteLine($"{code.Key}: {code.Value}");
        }
        Console.ReadKey();
    }
}

