using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class SecondLargestNumber
    {
        static void Main(string[] args)
        {
            int[] a = { 33,33333, 222, 1,  33144 };
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > largest)
                {
                    secondLargest = largest;
                    largest = a[i];
                }
            }
           
           
        }
    }
}
