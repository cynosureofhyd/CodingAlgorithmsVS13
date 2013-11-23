using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.BST
{
    public class BST
    {
        public int data { get; set; }
        public BST left { get; set; }
        public BST right { get; set; }
        public BST parent { get; set; }

        public static void InOrderRecursive(BST tree)
        {
            if (tree == null)
                return;
            else
            {
                InOrderRecursive(tree.left);
                Console.WriteLine(tree.data);
                InOrderRecursive(tree.right);
            }
        }

        public static void InOrderIterative(BST tree)
        {

        }

        public static void PreOrderRecursive(BST tree)
        {
            if (tree == null)
                return;
            else
            {
                Console.WriteLine(tree.data);
                PreOrderRecursive(tree.left);
                PreOrderRecursive(tree.right);
            }
        }

        public static void PostOrderRecursive(BST tree)
        {
            if (tree == null)
                return;
            else
            {
                Console.WriteLine(tree.data);
                PostOrderRecursive(tree.left);
                PostOrderRecursive(tree.right);
            }
        }

    }
}
