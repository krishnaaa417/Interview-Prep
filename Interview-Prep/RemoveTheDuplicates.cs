using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class RemoveTheDuplicates
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 4, 8, 0, 1, 7, 1, 4 };
            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        continue;
                    }
                }
            }
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
