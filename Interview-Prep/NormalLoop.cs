using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class NormalLoop
    {
        static void Main(string[] args)
        {
            //NormalLoop.WhileLoop();
            ForLoop();
        }

        //public static void WhileLoop()
        //{

        //    // sum of numbers from 1 to 5

        //    int i = 1;
        //    int j = 0;

        //    while (i <= 5)
        //    {
        //        j = i + j;
        //        Console.WriteLine(j);
        //        i++;
        //    }
        //}

        public static void ForLoop()
        {
            int total = 0;
            for (int i = 1; i <= 5; i++)
            {
                total += i;

            }
            Console.WriteLine("Total sum of the given number.." + total);
        }


    }
}
