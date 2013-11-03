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
            if(FirstList == null)
                PrintListReverseOrder(SecondList);
            
            if (SecondList == null)
                PrintListReverseOrder(FirstList);

            return 100;
            
        }

        private static int PrintListReverseOrder(LinkedList.Node list)
        {
            StringBuilder result = new StringBuilder();
            while(list != null)
            {
                result.Append(list.Value.ToString());
                PrintListReverseOrder(list.Next);
            }
            return Int32.Parse(result.ToString());
        }
    }
}
