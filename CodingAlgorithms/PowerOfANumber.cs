using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms
{
    //Please implement the function double Power(double base, int exponent) to raise a
    //number base to power of exponent. You are not allowed to call library functions, and it is not necessary to take
    //care of overflow issues.
    public class PowerOfANumber : IPowerOfNumber
    {
        public double Pow(double baseInput, int exponent)
        {
            double result = 1.0;
            if (exponent == 0)
                return baseInput;
            else if (exponent < 0)
                return 1 / Pow(baseInput, -exponent);
            else if(exponent > 0)
            {
                for(int i = 0 ; i < exponent; i++)
                {
                    result *= baseInput;
                }
            }
            return result;
        }
    }
}
