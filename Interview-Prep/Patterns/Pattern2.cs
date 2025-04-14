using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class Pattern2
    {
        static void Main(string[] args)
        {
            Pattern2.LeftAlignedRightAngleTriangle();
        }

        //*
        //* *
        //* * *
        //* * * *
        //* * * * *
        //* * * * * *

        public static void LeftAlignedRightAngleTriangle()
        {
            Console.WriteLine("please enter the rows you want");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the columns you wantt");
            int columns = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
