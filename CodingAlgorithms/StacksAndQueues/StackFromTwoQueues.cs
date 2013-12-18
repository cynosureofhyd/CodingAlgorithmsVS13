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
        
        // Constructor function
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
            // If Q2 is empty
            if(q2.GetSize() == 0)
            {
                // Push everything except last one into Q2
                while (q1.GetSize() > 1)
                    q2.Enqueue(q1.Dequeue());
                if (q1.GetSize() == 1)
                    result = q1.Dequeue();        
            }
            // If q2 has data
            else
            {
                while (q2.GetSize() > 1 && q1.GetSize() == 0)
                    q1.Enqueue(q2.Dequeue());
                result = q2.Dequeue();             
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
