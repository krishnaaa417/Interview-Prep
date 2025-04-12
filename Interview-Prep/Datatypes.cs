using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep
{
    internal class Datatypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a integer");
            int i = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine(i);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine("please enter your mobile number");
            long phonenumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("your contact number is.." + phonenumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            //Console.WriteLine("------------");
            //Console.WriteLine("please enter a Float number");
            //float f = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine(f);
            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(float.MaxValue);

            Console.WriteLine("Double.");
            Console.WriteLine("please enter your salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine("000----");
        }
    }
}
