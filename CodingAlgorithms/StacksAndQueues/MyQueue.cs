﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.StacksAndQueues
{
    public class MyQueue<T>
    {
        private int size = 0;
        private Object[] elements { get; set; }
        private static int DEFAULT_CAPACITY = 10;

        public MyQueue()
        {
            elements = new Object[DEFAULT_CAPACITY];
        }

        public void Enqueue(T element)
        {
            if (size == elements.Length)
            {
                ensureCapacity();
            }
            elements[size++] = (T)element;
        }

        public int GetSize()
        {
            return size;
        }

        public T Dequeue()
        {
            T e = (T)elements[0];
            elements = elements.Where((val, idx) => idx != 0).ToArray();
            //elements[0] = null;
            size--;
            return e;
        }

        private void ensureCapacity()
        {
            int newSize = elements.Length * 2;
            Array.Copy(elements, elements, newSize);
        }
    }
}
