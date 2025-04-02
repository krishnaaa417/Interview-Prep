using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class SmallestNumber
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 23, 44, 21, 22 };
            int max = int.MaxValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < max)
                {
                    max = a[i];
                }
            }

            Console.WriteLine("Smallest Value in the array."+max);
        }
    }
}
