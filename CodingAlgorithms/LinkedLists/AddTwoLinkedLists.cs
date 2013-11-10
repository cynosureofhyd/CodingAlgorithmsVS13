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
        public static int Add(LinkedList.Node FirstList, LinkedList.Node SecondList)
        {
            //if(FirstList == null)
            int secondNo = LinkedListToNumber(SecondList);
            
            if (SecondList == null)
                LinkedListToNumber(FirstList);

            return 100;
            
        }

        public static int LinkedListToNumber(LinkedList.Node list)
        {
            int result = 1;
            while(list != null)
            {
                LinkedListToNumber(list.Next);

            }
            return result;
        }
    }
}
