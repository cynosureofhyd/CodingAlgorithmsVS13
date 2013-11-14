using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.LinkedLists
{
    public class FindFirstInLoop
    {
        public static LinkedList.Node Find(LinkedList.Node list)
        {
            LinkedList.Node meetingnode = FindMeetingNode(list);
            LinkedList.Node temp = meetingnode;
            LinkedList.Node head = list;
            while (meetingnode != head)
            {
                head = head.Next;
                meetingnode = meetingnode.Next;
            }
            if (meetingnode == head)
                return head;
            else
                return null;
        }


        private static LinkedList.Node FindMeetingNode(LinkedList.Node list)
        {
            if (list == null)
                return null;
            LinkedList.Node first = list;
            LinkedList.Node second = list;

            while( first != null || second != null)
            {
                first = first.Next;
                if (first != null)
                    second = second.Next.Next;
                if (first == second)
                    return first;
            }
            return null;
        }
    }
}
