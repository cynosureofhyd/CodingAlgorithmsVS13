using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms
{
    public class FindMajorityInArray
    {
        // This method assumes we are given both positive and negative integers. 
        // It also works for arrays that contain integers only.

        // There are several ways I can think of solving this. 
        // First would be to go through all the elements in the array, and keep running count of 
        // each element with a hash table
        // Another would be to sort the array and then whatever element is in the middle would be the majority element
        // Let me try the 2nd method for now
        public static int Find(int[] array)
        {
            Array.Sort<int>(array);
            int t = array[array.Count()/2];
            return t;
        }
    }
}
