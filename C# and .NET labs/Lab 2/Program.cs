using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Arrays_and_LINQ
{
    
    class Lab2
    {
        static public int[] months = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
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
        public void NextDay(int d, int m, out int nextd, out int nextm)
        {
            nextd = d;
            nextm = m;
            if (m < 1 || m > 12) throw new ArgumentException("Invalid month");
            if (d < 1 || d > months[m - 1]) throw new ArgumentException("Invalid day for the given month");
            if (d == months[m - 1])
            {
                nextd = 1;
                nextm = m == 12 ? 1 : m + 1;
            }
            else
            {
                nextd = d + 1;
            }
           


        }/*
         public double AverageDouble(params[] nums)
         {
            



         }*/


    };
    class Task5
    {
        int numslength = 0;
        double[] numbers;
        public void Length(int length)
        {
            numslength = length;
            numbers = new double[length];
        }
        public void FillArray()
        {
            for (int i = 0; i < numslength; i++)
            {
                numbers[i]= Random.Shared.NextDouble() * 100; // Fill with random doubles between 0 and 100
            }
        }
        public void PrintArray()
        {
            Console.WriteLine("Array contents:");
            var numbers = from num in this.numbers
                          select num;
            foreach (var num in numbers)
            {
                Console.Write("{0:#.##}\t",num);
            }
        }
        public void FirstIndexOfZero()
        {
            // Non LINQ approach
            int indexOfZero = -1;
            for (int i = 0; i < numslength; i++)
            {
                if (numbers[i] > -1 && numbers[i] < 1)
                {
                    indexOfZero = i;
                    break;
                }
            }

            Console.WriteLine($"\nFirst index of zero (non-LINQ): {indexOfZero}");
            // LINQ approach
            int? idx = numbers.Select((num, i) => new { num, i }).FirstOrDefault(x => x.num > -1 && x.num < 1)?.i;

            if (idx == null) Console.WriteLine("There is no zero");
            else Console.WriteLine($"First index of zero (LINQ): {idx}");

        }
    }
    class Program
    {
        public static void Main()
        {
            Task5 task5 = new Task5();
            Lab2 task1 = new Lab2();
            int roots = task1.QuadraticEquation(a: 1, b: -3, c: 2, out double x1, out double x2);
            Console.WriteLine("Task 1:");
            Console.WriteLine($"Number of roots: {roots}");
            if (roots > 0)
            {
                Console.WriteLine($"x1: {x1}");
            }
            if (roots > 1)
            {
                Console.WriteLine($"x2: {x2}");
            }
           Console.WriteLine("\nTask 2:");
            try
            {
                task1.NextDay(31, 12, out int nextd, out int nextm);
                Console.WriteLine($"Next day: {nextd}/{nextm}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            task5.Length(100);
            task5.FillArray();
            Console.WriteLine("\nTask 5:");
            task5.PrintArray();
            task5.FirstIndexOfZero();

        }
    }

}