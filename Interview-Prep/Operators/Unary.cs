using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Operators
{
    internal class Unary
    {
        static void Main(string[] args)
        {
            //int a = -1;


            //Console.WriteLine(++a);
            //// ++a is pre increment operator, add +1 to a and then use the value

            //Console.WriteLine(a++);
            ////a++ is post increment operator, use the value first and then increment 1 

            //Console.WriteLine(a);
            Unary.Unaryy();
        }

        public static void Unaryy()
        {
            int a = 1;
            int b = 3;
            int c = (++a) + (b--);
            Console.WriteLine("Actual value of b.."+b);
            Console.WriteLine(c);
        }
    }
}
