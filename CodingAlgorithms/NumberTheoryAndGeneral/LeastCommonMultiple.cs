using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms
{
    public class LeastCommonMultiple
    {
        // Given two numbers calculate the least common multiple
        public static int Calculate(int firstNo, int secondNo)
        {
            int remainder = 0;
            if (firstNo < 0 || secondNo < 0)
                return Int32.MinValue;
            else
            {
                if(firstNo < secondNo)
                {
                    int temp = firstNo;
                    firstNo = secondNo;
                    secondNo = temp;
                }
               
                    remainder = firstNo % secondNo;
                    
                    if (remainder > 0)
                        return Calculate(secondNo, remainder);

                    if (remainder == 0)
                        return secondNo ;
                
            }
            return 0;
        }

        private static void Swap(int firstNo, int secondNo)
        {
         
        }
    }
}
