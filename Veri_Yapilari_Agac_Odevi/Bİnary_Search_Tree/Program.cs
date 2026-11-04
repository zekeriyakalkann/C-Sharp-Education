using System;

// Ağaç düğümünü tanımlayan sınıf
class TreeNode
{
    public int Key;
    public TreeNode Left, Right;

    public TreeNode(int item)
    {
        Key = item;
        Left = Right = null;
    }
}

// İkili Arama Ağacı sınıfı
class BinarySearchTree
{
    TreeNode root;

    // Ağaca yeni düğüm ekleme
    void Insert(int key)
    {
        root = InsertRec(root, key);
    }

    // Rekürsif olarak düğüm ekleyen yardımcı fonksiyon
    TreeNode InsertRec(TreeNode root, int key)
    {
        // Ağaç boşsa, yeni düğümü kök yap
        if (root == null)
        {
            root = new TreeNode(key);
            return root;
        }

        // Anahtar kök anahtarından küçükse, sol alt ağaçta ekle
        if (key < root.Key)
            root.Left = InsertRec(root.Left, key);
        // Anahtar kök anahtarından büyükse, sağ alt ağaçta ekle
        else if (key > root.Key)
            root.Right = InsertRec(root.Right, key);

        return root;
    }

    // Ağacı belirli bir anahtar için arama
    bool Search(int key)
    {
        return SearchRec(root, key) != null;
    }

    // Rekürsif olarak arama yapan yardımcı fonksiyon
    TreeNode SearchRec(TreeNode root, int key)
    {
        // Kök veya anahtar bulunursa
        if (root == null || root.Key == key)
            return root;

        // Anahtar kökten küçükse, sol alt ağaçta ara
        if (key < root.Key)
            return SearchRec(root.Left, key);

        // Anahtar kökten büyükse, sağ alt ağaçta ara
        return SearchRec(root.Right, key);
    }

    // Ana program
    static void Main(string[] args)
    {
        BinarySearchTree tree = new BinarySearchTree();

        // Kullanıcıdan ağaç için değerleri alma
        Console.WriteLine("Lütfen ağaç için değerleri girin, aralarında boşluk bırakarak:");
        string[] values = Console.ReadLine().Split(' ');

        foreach (var val in values)
        {
            tree.Insert(int.Parse(val));
        }

        // Kullanıcıdan aranacak değeri alma
        Console.WriteLine("Aramak istediğiniz değeri girin:");
        int key = int.Parse(Console.ReadLine());

        // Değerin ağaçta bulunup bulunmadığını kontrol etme
        if (tree.Search(key))
        {
            Console.WriteLine($"{key} değerini içeren düğüm ağaçta bulundu.");
        }
        else
        {
            Console.WriteLine($"{key} değerini içeren düğüm ağaçta bulunamadı.");
        }
        Console.ReadKey();
    }
}

