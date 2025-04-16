using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class HollowFullPyramid
    {
        static void Main(string[] args)
        {
            HollowFullPyramid.Hallow();
        }

        public static void Hallow()
        {
            int rows = 15;

            for (int i = 1; i <= rows; i++)
            {
                for (int spaces = 1; spaces <= rows - i; spaces++)
                {
                    Console.Write(" ");
                }
                for (int stars = 1; stars <= i; stars++)
                {
                    if (stars == 1 || stars == i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            for (int stars = 1; stars <= rows; stars++)
            {
                Console.Write("* ");
            }
        }
    }
}
