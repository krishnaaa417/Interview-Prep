using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class HourGlassPattern
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hour-Glass Pattern");
            HourGlassPattern.HourGlass();
        }

        private static void HourGlass()
        {
            int rows = 9;

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

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(' ');
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

    }
}
