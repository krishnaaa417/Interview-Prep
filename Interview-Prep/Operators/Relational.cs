using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Operators
{
    internal class Relational
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your age..");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18 && age < 1000)
            {
                Console.WriteLine("Congrats, you are eligible for voteee");
            }
            else
            {
                Console.WriteLine("sorry you are minorr");
            }

        }
    }
}
