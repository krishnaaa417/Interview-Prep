using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class StarPattern1
    {
        static void Main(string[] args)
        {
            //StarPattern1.Star();
            StarPattern1.Test();
        }

        public static void Star()
        {
            int rows = 6;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write("-");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Test()
        {
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 2 - i; j++)
                {
                    Console.Write("Venkat");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("-Krishna");
                }
            }
        }
    }
}
