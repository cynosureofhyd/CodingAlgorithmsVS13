using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.LinkedLists
{
    public class MergeTwoLinkedLists
    {
        // Merge two sorted linked lists 
        public static LinkedList.Node Merge(LinkedList.Node firstList, LinkedList.Node secondList)
        {
            LinkedList.Node firstLocalList = firstList;
            LinkedList.Node secondLocalList = secondList;
            
            if (firstLocalList == null)
                return secondLocalList;
            else if (secondLocalList == null)
                return firstLocalList;
            LinkedList.Node result = null;
            
            {
                if (firstLocalList.Value < secondLocalList.Value)
                {
                    result = LinkedList.Add(result, firstLocalList.Value);
                    result.Next = Merge(firstLocalList.Next, secondLocalList);
                }
                else if (firstLocalList.Value > secondLocalList.Value)
                {
                    LinkedList.Add(result, secondLocalList.Value);
                    result.Next = Merge(firstLocalList, secondLocalList.Next);
                }
                return result;
            }
        }
    }
}
