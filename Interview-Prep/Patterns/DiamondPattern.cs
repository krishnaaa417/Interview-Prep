using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class DiamondPattern
    {
        static void Main(string[] args)
        {
            DiamondPattern.Diamond();
            DiamondPattern.RevesePyramid();
        }

        public static void Diamond()
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
                Console.WriteLine();
            }  //Console.WriteLine();

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(' ');
                    }
                    for (int k = 1; k <= rows - i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }

        

        private static void RevesePyramid()
        {
            int rows = 7;
          

        }

    }
}
