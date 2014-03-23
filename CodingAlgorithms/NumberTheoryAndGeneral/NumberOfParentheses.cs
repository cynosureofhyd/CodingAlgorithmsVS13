using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms
{
    public class NumberOfParentheses
    {
        //private int MAX_SIZE;

        public static void Calculate(uint number)
        {
            if (number == 0 || number == 1)
                return;
            else
            {
                _printParenthesis(0, ((int)number), 0, 0, 1000);
            }
        }

        private static void _printParenthesis(int pos, int n, int open, int close, int MAX_SIZE)
        {
            StringBuilder str = new StringBuilder(MAX_SIZE);

            if (close == n)
            {
                Console.WriteLine(str);
                return;
            }
            else
            {
                if (open > close)
                {
                    str[pos] = '}';
                    _printParenthesis(pos + 1, n, open, close + 1, MAX_SIZE);
                }
                if (open < n)
                {
                    str[pos] = '{';
                    _printParenthesis(pos + 1, n, open + 1, close, MAX_SIZE);
                }
            }
        }
    }
}
