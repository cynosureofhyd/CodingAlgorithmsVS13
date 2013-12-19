using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingAlgorithms.LinkedLists;
using CodingAlgorithms.Trees;
using CodingAlgorithms.StacksAndQueues;

namespace CodingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {5, 7, 6, 9, 11, 10, 8};
            
            Console.WriteLine(IsBSTWithPostOrder.Check(array));
            //MyQueue<int> stack = new MyQueue<int>();
            //stack.Enqueue(20);
            //stack.Enqueue(40);
            //stack.Enqueue(60);


            //StackFromTwoQueues te = new StackFromTwoQueues();
            //te.Push(60);
            //te.Push(70);
            //te.Push(80);

            //int result = te.Pop(); // 80 first
            //result = te.Pop(); // 70 next
            //te.Push(90);
            //result = te.Pop(); // 90 last
            //result = te.Pop(); // 60 last

            //Console.WriteLine(stack.Dequeue());
            //StringToLong.Convert("-92233720368547758");
            //CreateBST.PrintInOrder();
            //LinkedList.Node firstList = CreateNode(4);
            //LinkedList.Node secondList = CreateNode(5);
            //List<int> randomArray = RandomArray.CreateRandomList(10);
            //LinkedList.Node firstSortedList = CreateSortedList(6, 1);

            //LinkedList.Node temp = firstSortedList;
            //while(temp.Next != null)
            //{
            //    temp = temp.Next;
            //}
            //temp.Next = firstSortedList.Next.Next;

            //LinkedList.Node firstNode = FindFirstInLoop.Find(firstSortedList);
            //bool isloop = LoopinLinkedList.IsLoop(temp);
            //LinkedList.Node secondSortedList = CreateSortedList(5, 6);
            //Int64 result = AddTwoLinkedLists.Add(firstList, secondList);

            //LinkedList.Node sortedList = MergeTwoLinkedLists.Merge(firstSortedList, secondSortedList);
            ////int lis = LongestIncreasingSubsequence.lis(randomArray);
            //bool result = BalancingParentheses.IsBalanced("[(){}]");
            //Console.WriteLine();
            //bool result1 = BalancingParentheses.IsBalanced("[()[]{}({}])");
            //bool result2 = BalancingParentheses.IsBalanced("[[[]]]");
            //bool result3 = BalancingParentheses.IsBalanced("[[[(())]]]{}{{[[[]]]}}()");
            //bool result4 = BalancingParentheses.IsBalanced("[[]][][[[]]");
            //bool result5 = BalancingParentheses.IsBalanced("{{}{]}[");
            //bool result6 = BalancingParentheses.IsBalanced("{{[[}}]]");
            //bool result7 = BalancingParentheses.IsBalanced("{]");
            //bool result8 = BalancingParentheses.IsBalanced("[()[]{}({}])");
            //bool result9 = BalancingParentheses.IsBalanced("(()))");
        }

        private static LinkedList.Node CreateNode(int number)
        {
            Random rand = new Random();
            LinkedList.Node newNode = LinkedList.Create(rand.Next(0, 10));
            for (int i = 0; i < number; i++ )
                newNode = LinkedList.Add(newNode, rand.Next(1, 10));

            return newNode;
        }

        private static LinkedList.Node CreateSortedList(int number, int? optionalstart = null)
        {
            LinkedList.Node newNode = null;
            int start = optionalstart != null ? optionalstart.Value : 0;
            number = start > 0 ? number + start : number;
            for (int i = start > 0 ? start : 0; i < number; i++)
                newNode = LinkedList.Add(newNode, i);
            return newNode;
        }
    }
}
