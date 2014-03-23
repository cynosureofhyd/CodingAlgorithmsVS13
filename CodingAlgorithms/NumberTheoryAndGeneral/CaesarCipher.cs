using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithms
{
    public class CaesarCipher
    {
        public static string Calculate(string input, int number)
        {
            input = input.ToLowerInvariant();
            StringBuilder sb = new StringBuilder(input);
            for (int i = 0; i < input.Length; i++)
            {
                if (number > 0 && Char.IsLetter(input[i]))
                {
                    char temp = (char)(input[i] + number % 26);
                    if(temp >= 'a' && temp <= 'z')
                    {
                        sb.Replace(input[i], temp, i, 1);
                    }
                    else if(temp > 'z')
                    {
                        char morethan = (char)(temp - 'z');
                        morethan = (char)('a' + morethan);
                        sb.Replace(input[i], morethan, i, 1);
                    }
                    // Not sure when I will get to this case
                    else if(temp < 'a')
                    {

                    }
                }
                if(number < 0 && Char.IsLetter(input[i]))
                {
                    int cal = number % 26;
                    char temp = (char)(input[i] + cal);
                    if(temp < 'a')
                    {
                        
                        char morethanz = (char)('z' + cal + input[i] - 'a');
                        sb.Replace(input[i], morethanz, i, 1);
                    }
                    else
                    {
                        sb.Replace(input[i], temp, i, 1);
                    }
                }
            }
            return sb.ToString();
        }
    }
}
