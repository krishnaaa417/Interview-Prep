using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class MaxNdMin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Max value is A.." + a);
            }
            else if (a < b)
            {
                Console.WriteLine("Max value is B.." + b);
            }
            else
            {
                Console.WriteLine("values are same");
            }
        }
    }
}
