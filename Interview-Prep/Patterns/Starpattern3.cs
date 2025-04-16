using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class Starpattern3
    {
        static void Main(string[] args)
        {
            //Starpattern3.Star3();
            Starpattern3.Star4();
        }

        private static void Star3()
        {
            int rows = 7;
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("-");
                }
                for (int k = 0; k <= rows - i; k++)
                {
                    Console.Write(k + 1 + i);
                }
                Console.WriteLine();
            }
        }

        private static void Star4()
        {
            int rows = 7;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("$");
                }
                for (int k = 0; k < rows - i; k++)
                {
                    Console.Write(k + 1);
                }
                Console.WriteLine();
            }
        }
    }
}
