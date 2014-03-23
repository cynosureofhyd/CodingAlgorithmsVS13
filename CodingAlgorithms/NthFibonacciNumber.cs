using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms
{
    public class NthFibonacciNumber
    {
        public static int Nth(int number)
        {
            return AdditiveSequence(number, 0, 1);
            //return 0;
        }

        private static int AdditiveSequence(int n, int t0, int t1)
        {
            if (n == 0) return t0;
            if (n == 1) return t1;
            return AdditiveSequence(n - 1, t1, t0 + t1);
        }
    }
}
