using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.LinkedLists
{
    public class FirstInLoopLinkedList
    {
        public static LinkedList.Node FirstInLoop(LinkedList.Node list)
        {
            //return new LinkedList.Node();
            if (list == null)
                return null;
            else
            {
                LinkedList.Node meetingNode = FindMeetingNode(list);

            }
        }

        private static LinkedList.Node FindMeetingNode(LinkedList.Node list)
        {
            LinkedList.Node p1 = list;
            LinkedList.Node p2 = list;

            while (list.Next != null || list != null || p2 != null)
            {
                list = list.Next;
                p2 = p2.Next.Next;
                if (p1 == p2)
                    return p1;
            }
            return null;
        }
    }
}
