using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Loops
{
    internal class InnerLoop2
    {
        static void Main(string[] args)
        {
            // excepted output : 1 2 3 4 5 6
            //1 2 3 4 5
            //1 2 3 4
            //1 2 3
            //1 2
            //1

            Console.WriteLine("please enter a number.");
            int loop = Convert.ToInt32(Console.ReadLine());

            for (int i = loop; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
