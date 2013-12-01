using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.Trees
{
    public class IsBST
    {
        public static bool Isit(BST tree)
        {
            if (tree == null)
                return false;
            else
            {
                if (tree.left != null && tree.left.data > tree.data)
                    return false;
                if (tree.right != null && tree.right.data < tree.data)
                    return false;
                if (!Isit(tree.left) || !Isit(tree.right))
                    return false;
                return true;
            }
        }

        private static bool Isitinternal(BST tree, int min, int max)
        {
            if (tree == null)
                return true;
            if (tree.data < min || tree.data > max)
                return false;
            return Isitinternal(tree.left, min, tree.data) && Isitinternal(tree.right, tree.data, max);
        }
    }
}
