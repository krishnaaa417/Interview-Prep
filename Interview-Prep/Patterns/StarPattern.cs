using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class StarPattern
    {
        static void Main(string[] args)
        {
            StarPattern.TriPattern();
        }

        public static void TriPattern()
        {
            int rows = 9;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (i == 1 || i == rows || j == 1 || j == rows)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
