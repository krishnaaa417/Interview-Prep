using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class NPattern3
    {
        //expected output
        //1
        //1 2
        //1 2 3
        //1 2 3 4
        //1 2 3 4 5
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
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
