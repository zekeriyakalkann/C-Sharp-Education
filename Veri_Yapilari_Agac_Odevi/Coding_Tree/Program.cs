using System;
using System.Collections.Generic;

// Huffman ağacı düğüm sınıfı
class HuffmanNode
{
    public char Character;
    public int Frequency;
    public HuffmanNode Left;
    public HuffmanNode Right;

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

        while (nodes.Count > 1)
        {
            nodes.Sort((x, y) => x.Frequency - y.Frequency);

            // İki en düşük frekanslı düğümü seç
            HuffmanNode left = nodes[0];
            HuffmanNode right = nodes[1];

            // Yeni bir iç düğüm oluştur
            HuffmanNode sum = new HuffmanNode('*', left.Frequency + right.Frequency);
            sum.Left = left;
            sum.Right = right;

            // İki düğümü listeden çıkar ve yeni düğümü ekle
            nodes.Remove(left);
            nodes.Remove(right);
            nodes.Add(sum);
        }

        return nodes[0];
    }

    // Huffman kodlarını üretme fonksiyonu
    public static void GenerateCodes(HuffmanNode root, string code, Dictionary<char, string> huffmanCodes)
    {
        if (root == null)
            return;

        // Yaprak düğüm
        if (root.Left == null && root.Right == null)
        {
            huffmanCodes[root.Character] = code;
        }

        GenerateCodes(root.Left, code + "0", huffmanCodes);
        GenerateCodes(root.Right, code + "1", huffmanCodes);
    }

    // Ana program
    static void Main(string[] args)
    {
        // Kullanıcıdan karakter frekanslarını alma
        Console.WriteLine("Lütfen karakterlerin ve frekanslarının aralarında boşluk bırakarak girin (örneğin: a 5 b 2 c 1):");
        string[] input = Console.ReadLine().Split(' ');

        var frequencies = new Dictionary<char, int>();

        for (int i = 0; i < input.Length; i += 2)
        {
            char character = input[i][0];
            int frequency = int.Parse(input[i + 1]);
            frequencies[character] = frequency;
        }

        // Huffman ağacını oluşturma
        var root = BuildHuffmanTree(frequencies);

        // Huffman kodlarını üretme
        var huffmanCodes = new Dictionary<char, string>();
        GenerateCodes(root, "", huffmanCodes);

        // Huffman kodlarını yazdırma
        Console.WriteLine("Huffman Kodları:");
        foreach (var code in huffmanCodes)
        {
            Console.WriteLine($"{code.Key}: {code.Value}");
        }
        Console.ReadKey();
    }
}
