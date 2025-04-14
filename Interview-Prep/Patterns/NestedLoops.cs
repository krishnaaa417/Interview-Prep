using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class NestedLoops
    {
        static void Main(string[] args)
        {
            NestedLoops.NestLoop();
        }

        public static void NestLoop()
        {
            //int k = 1;
            for (int i = 1; i <= 5; i++) // outer loops for columns
            {
                for (int j = 1,  k = 1; j <= 5; j++) //inner loops for rows
                {
                   
                        Console.Write(k + " ");
                        k++;
                   
                }
               
               
                Console.WriteLine();
            }
        }
    }
}
