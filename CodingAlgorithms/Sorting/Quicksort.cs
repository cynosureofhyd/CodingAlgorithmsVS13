using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.Sorting
{
    public class Quicksort
    {
        public static int partition(int[] array, int left, int right)
        {
            int pivot = array[left];

            int i = left + 1;
            for(int j = left + 1; j < right ; j++)
            {
                if (array[j] < pivot)
                   array = swap(array, j, i);
                i++;
            }
            array = swap(array, left, i - 1);
            return pivot;
        }

        private static int[] swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = array[i];
            return array;
        }
    }
}
