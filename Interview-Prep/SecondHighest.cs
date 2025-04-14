using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class SecondHighest
    {
        static void Main(string[] args)
        {
            int[] a = { 22, 1823, 63526, 4826252, 99 };
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > largest)
                {
                    secondLargest = largest;
                    largest = a[i];
                }

                else if (a[i] < largest && a[i] > secondLargest)
                {
                    secondLargest = a[i];
                }

                
            }
            if (largest == int.MinValue)
            {
                Console.WriteLine("Highest ELement Not Found..");
            }
            else
            {
                Console.WriteLine("Second-largest-Number.." + secondLargest);
            }
        }
    }
}
