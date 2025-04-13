using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Loops
{
    internal class Multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            int table = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(table * i);
            //}
            //second way
            for (int i = table; i <= table * 10; i = i + table)
            {
                Console.WriteLine(i);
            }
        }
    }
}
