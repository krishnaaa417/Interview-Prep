using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prep.Patterns
{
    internal class ReverseLeftAlignedRightAngleTriangle
    {
        static void Main(string[] args)
        {
            ReverseLeftAlignedRightAngleTriangle.AnotherApproach();
        }

        //* * * * *
        //* * * *
        //* * *
        //* *
        //*
        public static void ReverseLeftAlignedTriangle()
        {
            Console.WriteLine("please enter the rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the columns");
            int column = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows; j >= i; j--)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }

        }

        public static void AnotherApproach()
        {
            Console.WriteLine("please enter the rows");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row - i; j++)
                {
                    Console.Write("*" + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
