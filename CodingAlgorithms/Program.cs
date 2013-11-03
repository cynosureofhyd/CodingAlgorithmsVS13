using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList.Node firstNode = CreateNode(4);
            LinkedList.Node secondNode = CreateNode(5);
            List<int> randomArray = RandomArray.CreateRandomList(10);
            //int lis = LongestIncreasingSubsequence.lis(randomArray);
            bool result = BalancingParentheses.IsBalanced("[(){}]");
            Console.WriteLine();
            bool result1 = BalancingParentheses.IsBalanced("[()[]{}({}])");
            bool result2 = BalancingParentheses.IsBalanced("[[[]]]");
            bool result3 = BalancingParentheses.IsBalanced("[[[(())]]]{}{{[[[]]]}}()");
            bool result4 = BalancingParentheses.IsBalanced("[[]][][[[]]");
            bool result5 = BalancingParentheses.IsBalanced("{{}{]}[");
            bool result6 = BalancingParentheses.IsBalanced("{{[[}}]]");
            bool result7 = BalancingParentheses.IsBalanced("{]");
            bool result8 = BalancingParentheses.IsBalanced("[()[]{}({}])");
            bool result9 = BalancingParentheses.IsBalanced("(()))");
        }

        private static LinkedList.Node CreateNode(int number)
        {
            Random rand = new Random();
            LinkedList.Node newNode = LinkedList.Create(rand.Next(0, 100));
            for (int i = 0; i < number; i++ )
                LinkedList.Add(newNode, rand.Next(1, 100));

            return newNode;

        }
    }
}
