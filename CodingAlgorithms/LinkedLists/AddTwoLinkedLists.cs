using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.LinkedLists
{
    public class AddTwoLinkedLists
    {
        // This class is assuming the linkedlist consists of a number in reverse order
        // For ex. 1234 in linked list form is 4->3->2->1
        public static Int64 Add(LinkedList.Node FirstList, LinkedList.Node SecondList)
        {
            Int64 secondNo = 0 , firstNo = 0;
            if(SecondList != null)
                secondNo = LinkedListToNumber(SecondList);
            
            if (FirstList != null)
                firstNo = LinkedListToNumber(FirstList);

            Int64 result = firstNo + secondNo;
            //if(result > Int32.MaxValue)

            return (firstNo + secondNo);            
        }

        // Consider a list for example as 1->2->3->4->5->7. the value returned should be 754321
        public static int LinkedListToNumber(LinkedList.Node list)
        {
            int result = 0;
            LinkedList.Node temp = list;
            while(temp != null)
            {
                if (temp != null)
                    result = result * 10 + temp.Value;
                temp = temp.Next;
            }
            return result;
        }
    }
}
