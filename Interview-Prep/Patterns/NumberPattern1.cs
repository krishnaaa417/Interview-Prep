using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class NumberPattern1
    {
        static void Main(string[] args)
        {
            NumberPattern1.NumberPattern();
        }

        //
        //1
        //2 2
        //3 3 3
        //4 4 4 4
        //5 5 5 5 5
        public static void NumberPattern()
        {
            Console.WriteLine("please enter the row number");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
