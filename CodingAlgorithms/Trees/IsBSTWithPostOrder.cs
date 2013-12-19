using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.Trees
{
    // Given an array with certain values and assuming no duplicates. 
    // For example  {5, 7, 6, 9, 11, 10, 8} forms a BST and the given array is a BST
    public class IsBSTWithPostOrder
    {
        public static bool Check(int[] array)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            if (array.Count() > 0)
            {
                int lastNo = array.Last();

                // Find the left array
                for(int i = 0; i < array[array.Count() - 1]; i++)
                {
                    if(array[i] < lastNo)
                    {
                        left.Add(array[i]);
                    }
                    if (array[i] > lastNo)
                        break;
                }                

                // Find the right array
                for (int i = 0; i < array[array.Count() - 1]; i++)
                {
                    if (array[i] > lastNo)
                    {
                        right.Add(array[i]);
                    }
                    if (array[i] < lastNo)
                        break;
                }

                return Check(left.ToArray()) && Check(right.ToArray());
            }
            else
                return false;
            return true;
        }
    }
}
