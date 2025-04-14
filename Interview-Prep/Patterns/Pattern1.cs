using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class Pattern1
    {
        static void Main(string[] args)
        {
            Pattern1.PatternType1();
        }

        //Excepted-Output :
        //    * * * * *
        //    * * * * *
        //    * * * * *
        //    * * * * * 
        //    * * * * *
        public static void PatternType1()
        {
            Console.WriteLine("Please enter your rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your columns");
            int columns = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)  // this for rowss bro
            {
                for (int j = 1; j <= columns; j++)  // this is for columsn
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
