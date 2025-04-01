using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class SwappingWithoutThirdVariable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("before swapping." + a);
            Console.WriteLine("before swapping."+b);
            a = a + b; // 10+20 = 30
            b = a - b; //10
            a = a - b; //20
            Console.WriteLine("after swapping." + a);
            Console.WriteLine("after swapping."+b);
        }
    }
}
