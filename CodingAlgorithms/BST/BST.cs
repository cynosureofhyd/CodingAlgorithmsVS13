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
            bool isDone = false;
            if(tree != null)
            {
                BST current = tree;
                Stack<BST> stack = new Stack<BST>();
                while (!isDone)
                {
                    if (current != null)
                    {
                        stack.Push(current);
                        current = current.left;
                    }
                    if(current == null && stack.Count > 0) 
                    {
                        BST nodetoprint = stack.Pop();
                        Console.WriteLine(nodetoprint.data);
                        current = current.right;
                    }
                    if (current == null && stack.Count == 0)
                    {
                        isDone = true;
                        return;
                    }
                }
            }
        }

        public static void PostOrderIterative(BST tree)
        {

        }

        public static void PostOrderRecursive(BST tree)
        {
            if (tree == null)
                return;
            else
            {
                PostOrderRecursive(tree.left);
                PostOrderRecursive(tree.right);
                Console.WriteLine(tree.data);
            }
        }

        public static void PreOrderIterative(BST tree)
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
    }
}
