using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class NumberPattern4
    {
        static void Main(string[] args)
        {
            // NumberPattern4.NumberPattern();
            NumberPattern4.NumberPattern2();
        }

        private static void NumberPattern()
        {
            int rows = 9;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        private static void NumberPattern2()
        {
            for (int i = 1; i <= 9; i++)
            {


                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i-j+1+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
