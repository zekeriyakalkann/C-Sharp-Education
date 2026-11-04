using System;

namespace Ikili_Agac
{
    // a. Ağacın düğümünü ve yapılandırıcı metodu yazınız (5p)
    public class TreeNode // Düğüm sınıfı
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    // b. Kullanıcıdan gelen sayılara göre kök yoksa köke, varsa kökten küçükse kökün soluna, kökten büyükse kökün sağına yerleştirecek ağaç için gerekli kodu yazınız. (15p)
    public class BinaryTree
    {
        public TreeNode Root;

        // Yapıcı metot
        public BinaryTree()
        {
            Root = null;
        }

        // Ağaca değer ekleme metodu
        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new TreeNode(value);
            }
            else
            {
                AddRecursively(Root, value);
            }
        }

        // Rekürsif ekleme metodu
        private void AddRecursively(TreeNode node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode(value);
                }
                else
                {
                    AddRecursively(node.Left, value);
                }
            }
            else if (value > node.Value)
            {
                if (node.Right == null)
                {
                    node.Right = new TreeNode(value);
                }
                else
                {
                    AddRecursively(node.Right, value);
                }
            }
        }

        // c. Sil (node root, int data) fonksiyonunun C# kodunu yazınız. (15p)
        public TreeNode Delete(TreeNode root, int data)
        {
            if (root == null)
            {
                return root;
            }

            if (data < root.Value)
            {
                root.Left = Delete(root.Left, data);
            }
            else if (data > root.Value)
            {
                root.Right = Delete(root.Right, data);
            }
            else
            {
                // Yaprak düğüm durumu (çocuğu olmayan düğüm)
                if (root.Left == null && root.Right == null)
                {
                    return null;
                }
                // Tek çocuk durumu
                else if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                // İki çocuk durumu
                root.Value = MinValue(root.Right);
                root.Right = Delete(root.Right, root.Value);
            }

            return root;
        }

        // En küçük değeri bulma metodu
        private int MinValue(TreeNode node)
        {
            int minValue = node.Value;

            while (node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }

            return minValue;
        }

        // d. Bul(int data) fonksiyonunun C# kodunu yazınız. (10p)
        public TreeNode Search(TreeNode node, int data)
        {
            if (node == null || node.Value == data)
            {
                return node;
            }

            if (data < node.Value)
            {
                return Search(node.Left, data);
            }
            else
            {
                return Search(node.Right, data);
            }
        }

        // e. Min() fonksiyonunun C# kodunu yazınız. (5p)
        public int Min()
        {
            if (Root == null)
            {
                Console.WriteLine("Ağaç boş");
            }

            return MinValue(Root);
        }

        // Ağacı sıralı yazdırma metodu
        public void PrintTree(TreeNode node)
        {
            if (node != null)
            {
                PrintTree(node.Left);
                Console.Write(node.Value + " ");
                PrintTree(node.Right);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            while (true)
            {
                Console.WriteLine("Lütfen bir sayı girin (çıkmak için -1 girin): ");
                int value = int.Parse(Console.ReadLine());

                if (value == -1) break;

                tree.Add(value);
            }

            Console.WriteLine("İkili ağaç: ");
            tree.PrintTree(tree.Root);

            Console.WriteLine("\nSilmek istediğiniz sayıyı girin: ");
            int deleteValue = int.Parse(Console.ReadLine());
            tree.Root = tree.Delete(tree.Root, deleteValue);

            Console.WriteLine("Güncellenmiş ikili ağaç: ");
            tree.PrintTree(tree.Root);

            Console.WriteLine("\nAramak istediğiniz sayıyı girin: ");
            int searchValue = int.Parse(Console.ReadLine());
            TreeNode foundNode = tree.Search(tree.Root, searchValue);
            if (foundNode != null)
            {
                Console.WriteLine($"{searchValue} bulundu.");
            }
            else
            {
                Console.WriteLine($"{searchValue} bulunamadı.");
            }

            Console.WriteLine($"\nAğacın minimum değeri: {tree.Min()}");
            Console.ReadKey();
        }
    }
}
