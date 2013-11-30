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

            if (String.IsNullOrEmpty(str))
                return Int64.MinValue;
            else
            {
                int i = 0; 
                foreach(char c in str)
                {
                    // To check to see if we are converting only the integer part of the string
                    // And also to check to see if we are having a value lesser than max value of int
                    if(c != '.' && (result * 10 < Int64.MaxValue) && IsNumber(c))
                    {
                        result = result * 10 + ConvertChartoInt(c);
                    }
                }
                return result;
            }
        }

        private static bool IsNumber(char c)
        {
            if (char.IsWhiteSpace(c))
                return false;
            int charactertonumber = (int)c - (int)'0';
            if (charactertonumber >= 0 && charactertonumber <= 9)
                return true;
            else
                return false;
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
