using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.Trees
{
    public class NextNodeInBST
    {
        public static BST NextNode(BST tree)
        {
            if (tree == null)
                return null;
            else
            {
                // If a node has a right node, the next node is the left most node in the right sub tree
                if(tree.right != null)
                {
                    BST current = tree.right;
                    while(current != null)
                    {
                        current = current.left;
                    }
                    return current;
                }
                // If a node does not have a right node and is the left child of its parent,
                // then next node is its parent
                else if(tree.right == null && tree.Parent != null && tree.Parent.left == tree)
                {
                    return tree.Parent;
                }
                else if(tree.right == null && tree.Parent != null)
                {
                    BST parent = tree.Parent;
                    
                }

                // If a node does not have a right node and is the right child of its parent, then next node is the node which is the left child of its parent. Then the parent is the next node
            }
            return new BST();
        }
    }
}
