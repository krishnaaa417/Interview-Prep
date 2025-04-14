using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class RightAlingedDecreaseTriangle
    {
        static void Main(string[] args)
        {
            RightAlingedDecreaseTriangle.Approach1();
        }

 //* * * * *
 // * * * *
 //   * * *
 //     * *
 //       *

        public static void Approach1()
        {
            Console.WriteLine("please enter your row number");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int spaces = 1; spaces <i; spaces++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= row-i ; j++)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
