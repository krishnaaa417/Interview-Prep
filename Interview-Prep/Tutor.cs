using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class Tutor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a boolean value..");
            try
            {
                bool b = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine(b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
