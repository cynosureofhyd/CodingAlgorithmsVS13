using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.Trees
{
    public class CreateBST
    {
        public static BST NextNodeProblem()
        {
            BST newnode = new BST();
            newnode = BST.CreateBST(1);
            newnode.left = BST.CreateBST(2);
            newnode.right = BST.CreateBST(3);
            newnode.left.left = BST.CreateBST(4);
            newnode.left.right = BST.CreateBST(5);
            newnode.right.left = BST.CreateBST(6);
            newnode.right.right = BST.CreateBST(7);
            newnode.left.right.left = BST.CreateBST(8);
            newnode.left.right.right = BST.CreateBST(9);
            return newnode;
        }

        public static void PrintInOrder()
        {
            BST.InOrderIterative(NextNodeProblem());
        }
    }
}
