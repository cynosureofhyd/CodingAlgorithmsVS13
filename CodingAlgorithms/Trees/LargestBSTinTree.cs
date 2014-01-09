using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.Trees
{
    public class LargestBSTinTree
    {
        public static BST Calculate(BST tree)
        {
            if (tree == null)
                return null;

            return null;
        }

        private static int sizebst(BST tree)
        {
            if (tree == null)
                return 0;
            return sizebst(tree.left) + sizebst(tree.right) + 1;


        }

        private static bool IsBst(BST tree)
        {
            return IsBSTWrapper(tree, Int32.MinValue, Int32.MaxValue);
        }

        private static bool IsBSTWrapper(BST tree, int min, int max)
        {
            if (tree == null)
                return false;
            if (tree.data > min || tree.data < max)
                return false;
            return IsBSTWrapper(tree.left, min, tree.data) && IsBSTWrapper(tree.right, tree.data, max);
        }
    }
}
