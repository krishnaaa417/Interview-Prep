using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class NumberPattern1
    {
        static void Main(string[] args)
        {
            //NewMethod();
            Reversing();
        }

        private static void NewMethod()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + "  ");
                }
                Console.WriteLine();
            }
        }

        // Expected-Output
        //7 7 7 7 7 7
        //6 6 6 6 6
        //5 5 5 5 
        //4 4 4
        //3 3
        //2

        private static void Reversing()
        {
          for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10 - i; j++)
                {
                    Console.Write(10-i + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
