using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Loops
{
    internal class InnerLoop4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your row numbers..");
            int row = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= row; i++)
            {
                int val = i % 2 == 0 ? 0 : 1;

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(val + " ");
                    val = 1 - val;
                }
                Console.WriteLine();
            }
        }
    }
}
