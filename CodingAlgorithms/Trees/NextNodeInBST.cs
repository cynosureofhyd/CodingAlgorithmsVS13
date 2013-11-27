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
                if(tree.right != null)
                {
                    BST current = tree.right;
                    while(current != null)
                    {
                        current = current.left;
                    }
                    return current;
                }
            }
            return new BST();
        }
    }
}
