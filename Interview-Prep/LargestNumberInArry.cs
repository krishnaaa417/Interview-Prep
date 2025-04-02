using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class LargestNumberInArry
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 7, 1, 9, 6 };
            int temp = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (temp < a[i])
                {
                    temp = a[i];
                }
            }
            Console.WriteLine("Largest element in an AArray.."+ temp);
        }
    }
}
