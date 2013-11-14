using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.LinkedLists
{
    public class LoopinLinkedList
    {
        public static bool IsLoop(LinkedList.Node list)
        {
            if (list == null)
                return false;
            else
            {
                LinkedList.Node head = list;
                LinkedList.Node second = list;
                while (head.Next != null || head != null || second != null)
                {
                    head = head.Next;
                    second = second.Next.Next;
                    if (head == second)
                        return true;
                }
            }
            return false;
        }
    }
}
