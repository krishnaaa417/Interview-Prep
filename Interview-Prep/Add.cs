using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class Add
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;

            Console.WriteLine("sum of your two numbers is.."+c);
        }
    }
}
