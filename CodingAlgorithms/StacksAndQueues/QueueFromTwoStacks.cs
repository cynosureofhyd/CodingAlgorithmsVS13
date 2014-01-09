using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.StacksAndQueues
{
    public class QueueFromTwoStacks
    {
        private MyStack<int> st1;
        private MyStack<int> st2;

        public QueueFromTwoStacks()
        {
            st1 = new MyStack<int>();
            st2 = new MyStack<int>();
        }

        public void Enqueue(int data)
        {
            //if(st2.GetSize() == 0)
            //{
                st1.Push(data);
            //}
        }

        public int Dequeue()
        {
            if (st2.GetSize() == 0)
            {
                while (st1.GetSize() > 1)
                {
                    st2.Push(st1.Pop());
                }
                return st1.Pop();
            }
            if(st2.GetSize() == 0)
                throw new InvalidOperationException("Queue is empty");
            return st2.Pop();
            //return 0;
        }
    }
}
