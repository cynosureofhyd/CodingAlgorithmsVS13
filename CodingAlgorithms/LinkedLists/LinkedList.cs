using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms
{
    public class LinkedList
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
        }

        public static Node Create(int value)
        {
            Node newNode = new Node()
            {
                Value = value,
                Next = null
            };
            head = newNode;   
            return head;
        }

        private int size;
        public int Count
        {
            get
            {
                return size;
            }
        }

        public static Node head;

        public static Node Add(Node addNode, int data)
        {
            if(addNode == null)
            {
                return Create(data);
            }
            Node newNode = Create(data);
            newNode.Next = addNode;
            addNode = newNode;
            return addNode;
        }
    }
}
