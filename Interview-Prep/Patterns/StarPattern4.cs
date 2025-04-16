using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class StarPattern4
    {
        static void Main(string[] args)
        {
            //StarPattern4.SpecialPattern();
            StarPattern4.ReturnPattern();
        }

        public static void SpecialPattern()
        {
            int rows = 10;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (int k = 0; k < (2 * rows - 2 * (i + 1)); k++)
                {
                    Console.Write(" ");
                }

                for (int s = 0; s <= i; s++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        private static void ReturnPattern()
        {
            int rows = 10;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write("*");
                }

                for (int k = 1; k <=i; k++)
                {
                    Console.Write(" ");
                }

                for (int s = 1; s <= rows - i; s++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
