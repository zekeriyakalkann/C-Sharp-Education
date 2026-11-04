using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Veri_yapilari_Calisma
{
    //a. ağacın düğümünü ve yapılandırıcı metodonu yazınız.

    public class TreeNode
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


    // b. Kullanıcıdan gelen sayılara göre kök yoksa köke, varsa kökten küçükse kökün soluna, kökten büyükse kökün sağına yerleştirecek ağaç için gerekli kodu yazınız.
    public class BinaryTree
    {
        public TreeNode Root;
        public BinaryTree()
        {
            Root = null;
        }

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new TreeNode(value);
            }

            else
            {
                AddRecursive(Root, value);
            }
        }

        private void AddRecursive(TreeNode node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode(value);
                }

                else
                {
                    AddRecursive(node.Left, value);
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
                    AddRecursive(node.Right, value);
                }
            }
        }

        // c. Sil (node root, int data) fonksiyonunun C# kodunu yazınız.

        public TreeNode Delete(TreeNode root, int data)
        {
            if (root == null)
            {
                return null;
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
                if (root.Left == null && root.Right == null)
                {
                    return root;
                }
                else if (root.Left == null)
                {
                    return root.Right;
                }

                else if (root.Right == null)
                {
                    return root.Left;
                }



            }
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
