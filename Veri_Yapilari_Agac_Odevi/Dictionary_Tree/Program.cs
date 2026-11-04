using System;
using System.Collections.Generic;

// Trie düğüm sınıfı
class TrieNode
{
    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    public bool EndOfWord;

    public TrieNode()
    {
        EndOfWord = false;
    }
}

// Trie sınıfı
class Trie
{
    private TrieNode root;

    public Trie()
    {
        root = new TrieNode();
    }

    // Trie'ye kelime ekleme
    public void Insert(string word)
    {
        TrieNode current = root;
        foreach (char c in word)
        {
            if (!current.Children.ContainsKey(c))
            {
                current.Children[c] = new TrieNode();
            }
            current = current.Children[c];
        }
        current.EndOfWord = true;
    }

    // Trie içinde kelime arama
    public bool Search(string word)
    {
        TrieNode current = root;
        foreach (char c in word)
        {
            if (!current.Children.ContainsKey(c))
            {
                return false;
            }
            current = current.Children[c];
        }
        return current.EndOfWord;
    }

    // Kullanıcıdan alınan dizelerle trie oluşturan ve arama yapan ana program
    static void Main(string[] args)
    {
        Trie trie = new Trie();

        // Kullanıcıdan kelimeleri alma
        Console.WriteLine("Lütfen trie için kelimeleri girin, her bir kelimeyi bir boşlukla ayırarak girin:");
        string[] words = Console.ReadLine().Split(' ');

        foreach (string word in words)
        {
            trie.Insert(word);
        }

        // Kullanıcıdan aranacak kelimeyi alma
        Console.WriteLine("Aramak istediğiniz kelimeyi girin:");
        string searchWord = Console.ReadLine();

        // Kelimenin trie içinde olup olmadığını kontrol etme
        if (trie.Search(searchWord))
        {
            Console.WriteLine($"{searchWord} trie içinde bulundu.");
        }
        else
        {
            Console.WriteLine($"{searchWord} trie içinde bulunamadı.");
        }
        Console.ReadKey();
    }
}

