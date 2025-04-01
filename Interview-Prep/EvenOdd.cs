using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {



            Console.WriteLine("please enter a number..");
            int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter second number..");
            //int b = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Even-Number");
            }
            else
            {
                Console.WriteLine("Odd-Number..");
            }


        }
    }
}
