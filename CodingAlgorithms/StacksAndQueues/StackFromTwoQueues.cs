using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.StacksAndQueues
{
    public class StackFromTwoQueues
    {
        private MyQueue<int> q1;
        private MyQueue<int> q2;
        

        public StackFromTwoQueues()
        {
            q1 = new MyQueue<int>();
            q2 = new MyQueue<int>();
        }
        public void Push(int element)
        {
            if (q2.GetSize() != 0)
                q2.Enqueue(element);
            else
                q1.Enqueue(element);
        }

        public int Pop()
        {
            if (q1.GetSize() == 0 && q2.GetSize() == 0)
                throw new InvalidOperationException();
            int result = 0; 
            if(q2.GetSize() == 0)
            {
                while (q1.GetSize() > 1)
                    q2.Enqueue(q1.Dequeue());
                if (q1.GetSize() == 1)
                    result = q1.Dequeue();
                //if()
            }
            else
            {
                return q2.Dequeue();
            }
            return result;
        }
    }
}
