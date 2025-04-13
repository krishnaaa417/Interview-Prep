using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Loops
{
    internal class InnerLoop5
    {
        static void Main(string[] args)
        {
            int n = 6; 

            for (int i = 0; i < n; i++)
            {
                
                for (int s = 0; s < i; s++)
                {
                    Console.Write(" ");
                }

                
                for (int j = i + 1; j <= n; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine(); 
            }
        }
    }
}
