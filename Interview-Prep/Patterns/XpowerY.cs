using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class XpowerY
    {
        static void Main(string[] args)
        {
            // XpowerY.XpowerYForLoop();
            //XpowerY.XpowerYWhileLoop();
            XpowerYAnotherMethod();
        }

        public static void XpowerYForLoop()
        {
            Console.WriteLine("please enter the first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int y = Convert.ToInt32(Console.ReadLine());

            int power = 1;

            for (int i = 1; i <= y; i++)
            {
                power *= x;

            }
            Console.WriteLine("power of x and y :-" + power);
        }

        public static void XpowerYWhileLoop()
        {
            Console.WriteLine("please enter the first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int y = Convert.ToInt32(Console.ReadLine());

            int power = 1;
            int i = 1;

            while (i <= y)
            {
                power *= x;
                i++;
            }
            Console.WriteLine(power);
        }

        public static void XpowerYAnotherMethod()
        {
            Console.WriteLine("please enter the first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int y = Convert.ToInt32(Console.ReadLine());

            int power = 1;
           

            for (int i = y; i >= 1; i--)
            {
                power = power * x;

            }
            Console.WriteLine("Reverse the thingss.."+power);

        }
    }
}
