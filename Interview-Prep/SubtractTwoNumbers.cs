using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class SubtractTwoNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sub(10, 20));
            Console.WriteLine(Mul(10, 20));
            Console.WriteLine(Div(10, 20));
            Console.WriteLine(Mod(10, 20));
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static  int Mul(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }

        public static  int Mod(int a, int b)
        {
            return (a % b);
        }
    }
}
