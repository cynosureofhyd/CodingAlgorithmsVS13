using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms.StacksAndQueues
{
    public class MyStack<T>
    {
          private int size = 0;
          private static int DEFAULT_CAPACITY = 10;
          private Object[] elements;

          public MyStack() {
            elements = new Object[DEFAULT_CAPACITY];
          }

          public int GetSize()
          {
              return size;
          }

          public void Push(T e) {
            if (size == elements.Length) {
              ensureCapacity();
            }
            elements[size++] = e;
          }

          public T Pop() {
            T e = (T) elements[--size];
            elements[size] = null;
            return e;
          }

          private void ensureCapacity() {
            int newSize = elements.Length * 2;
            Array.Copy(elements, elements, newSize);
          }
    }
}
