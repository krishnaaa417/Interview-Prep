using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class ConvertRomanToInt
    {
        static void Main(string[] args)
        {
            Console.WriteLine( RomanToInt("XI"));
        }

        public static int RomanToInt(string s)
        {
            int[] val = { 1000, 500, 100, 50, 10, 5, 1 };
            char[] sym = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };

            int result = 0; // final result
            int pre = 0; // previous value while traversing

            for (int i = s.Length - 1; i >= 0; i--)
            {
                char currentChar = s[i];

                for (int j = 0; j < sym.Length; j++)
                {
                    if (currentChar == sym[j])
                    {
                        if (val[j] < pre) // If current value is smaller than previous one
                        {
                            result -= val[j]; // Subtract it
                        }
                        else
                        {
                            result += val[j]; // Otherwise, add it
                        }

                        pre = val[j];
                        break;
                    }
                }
            }

            return result;

        }
    }
}
