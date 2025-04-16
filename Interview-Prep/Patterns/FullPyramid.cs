using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class FullPyramid
    {
        static void Main(string[] args)
        {
            FullPyramid.Pyramid();
        }

        public static void Pyramid()
        {
            int rows = 7;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }

                //for (int j = 1; j <= rows - i; j++)
                //{
                //    Console.Write(" ");
                //}

                Console.WriteLine();
            }
        }

    }
}
