using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Loops
{
    // expected output
    //1
    //2 3
    //4 5 6
    //7 8 9 10
    internal class InnerLoop3
    {
        static void Main(string[] args)
        {
            int num = 1;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num +" ");
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
}
