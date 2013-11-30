using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms
{
    public class StringToLong
    {
        // We would input the long number if str could be converted to a valid long
        // else we would return int64.min number. Also we are assuming the str is only a integer number
        public static long Convert(string str)
        {
            Int64 result = 0;
            float decimalhalf = 0.0;
            if (String.IsNullOrEmpty(str))
                return Int64.MinValue;
            else
            {
                int i = 0; 
                foreach(char c in str)
                {
                    if(c != '.')
                    {
                        result = result * 10 +  ConvertChartoInt(c);
                    }
                    else
                    {

                    }
                }
                return result;
            }
        }

        private static int ConvertChartoInt(char c)
        {
            if (Char.IsWhiteSpace(c))
                return Int32.MinValue;
            else
                return (int)c  - (int)'0';
        }
    }
}
