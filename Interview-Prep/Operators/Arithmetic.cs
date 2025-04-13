using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Operators
{
    internal class Arithmetic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( "Addition"+","+(first + second));
            Console.WriteLine("Subtraction :-"+(first - second));
            Console.WriteLine("Multiplication:-" + (first * second));
            Console.WriteLine("Divider:-" + (first / second));
            Console.WriteLine("Modulus:-"+(first % second));
        }
    }
}
