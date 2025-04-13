using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Loops
{
    // problem :-Take input from the user, if the input is odd, then print  ,1,3,5,7,9 
    // If it is even then print 0,2,4,6,8,10

    internal class EvenOrOdd
    {
        static void Main(string[] args)
        {
            //step:1 take the input from the user
            Console.WriteLine("please enter a number");
            int odd = Convert.ToInt32(Console.ReadLine());
            if (odd % 2 != 0)
            {
                for (int i = 1; i <= 10; i=i+2)
                {
                    Console.WriteLine("Odd-Even."+i);
                }
            }
            else
            {
                for (int i = 0; i <= 10; i = i + 2)
                {
                    Console.WriteLine("Even-num.."+i);
                }
            }
        }
    }
}