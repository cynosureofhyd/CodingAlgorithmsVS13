using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.Trees
{
    public class BST
    {
        public int data { get; set; }
        public BST left { get; set; }
        public BST right { get; set; }
        public BST Parent { get; set; }

        public BST CreateBST(int data)
        {
            return new BST()
            {
                data = data,
                left = null,
                right = null
            };
        }

        public bool ValueExists(BST tree, int data)
        {
            if (tree == null)
                return false;
            if (tree.data == data)
                return true;
            else
                return ValueExists(tree.left, data) || ValueExists(tree.right, data);
        }

        public void InOrder(BST tree)
        {
            if (tree == null)
                return;
            else
            {
                InOrder(tree.left);
                Console.WriteLine(tree.data);   
                InOrder(tree.right);
                
            }
        }

        public void PreOrderIterative(BST tree)
        {
            if (tree == null)
                return;
            else
            {
                Stack<BST> stack = new Stack<BST>();
                stack.Push(tree);
                while(stack.Count > 0)
                {
                    BST currentBST = stack.Pop();
                    Console.WriteLine(currentBST.data);
                    if (currentBST.left != null)
                        stack.Push(currentBST.left);
                    if (currentBST.right != null)
                        stack.Push(currentBST.right);
                }
            }
        }

        // In Order Iterative - First push all the left elements into a stack
        // Once all the left elements are pushed, then print the current elements data - which would be left first and then
        // push the right elements into stack
        public void InOrderIterative(BST tree)
        {
            if (tree == null)
                return;
            BST current = tree;
            
            Stack<BST> stack = new Stack<BST>();
            stack.Push(current);
            while(current != null)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                else
                {
                    if (current == null && stack.Count > 0)
                    {
                        BST nodeToPrint = stack.Pop();
                        Console.WriteLine(nodeToPrint.data);
                        current = (current.right);
                    }
                    if (current == null && stack.Count == 0)
                        return;
                }
            }
        }

        public void PreOrder(BST tree)
        {
            if (tree == null)
                return;
            else
            {
                Console.WriteLine(tree.data);
                InOrder(tree.left);
                InOrder(tree.right);
            }
        }

        public void PostOrder(BST tree)
        {
            if (tree == null)
                return;
            else
            {
                InOrder(tree.left);
                InOrder(tree.right);
                Console.WriteLine(tree.data);
            }
        }

    }
}
