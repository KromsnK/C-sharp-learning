using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_and_LINQ
{
    class Lab2
    {
        public int QuadraticEquation(float a,float b,float c, out double x1,out double x2)
        {
            double D = b*b - 4 * a * c;
            if (D < 0)
            {
                x1 = x2 = 0;
                return 0;
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                return 1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return 2;
            }
        }
        public int NextDay()
        {

        }
        public double AverageDouble(params[] nums)
        {
            var numbers = nums.OfType<double>();

                         

        }
    };
    class Program
    {
        public static void Main()
        {
            Lab2 task1 = new Lab2();
            int roots = task1.QuadraticEquation(a: 1, b: -3, c: 2, out double x1, out double x2);
            Console.WriteLine($"Number of roots: {roots}");
            if (roots > 0)
            {
                Console.WriteLine($"x1: {x1}");
            }
            if (roots > 1)
            {
                Console.WriteLine($"x2: {x2}");
            }

        }
    }

}