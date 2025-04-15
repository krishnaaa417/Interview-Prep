using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class NumberPattern5
    {
        static void Main(string[] args)
        {
            int rows = 7;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(rows-j-i + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
