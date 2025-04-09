using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class PalindromeNumber
    {
        static void Main(string[] args)
        {
            int number = 121;
            int reversenumber = 0;
            int palindrome = number;

            while (number > 0)
            {
                int num = number % 10;
                reversenumber = reversenumber * 10 + num;
                number = number / 10;
            }

            if (reversenumber == palindrome)
            {
                Console.WriteLine("Your number is Palindrome..");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
