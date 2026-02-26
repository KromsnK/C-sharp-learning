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
        // 2
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
           


        }
        // 3
         public double AverageDouble(params double[] nums)
         {
            if (nums.Length == 0)
            {
              throw new ArgumentException("At least one number is required to calculate the average");
            }
            double sum = 1.0;
            for(int i = 0; i<nums.Length;i++)
            {
                if (nums[i] < 0) throw new ArgumentException("Negative numbers are not allowed for geometric mean");
                if (nums[i] == 0) return 0; // If any number is zero, the geometric mean is zero
                sum *= nums[i];
            }
            return Math.Pow(sum,1.0/nums.Length);
        }
        // 4
        public void Distance()
        {
            double Distance(double x1, double y1, double x2, double y2) => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Distance between (1,2) and (4,6) is {Distance(1, 2, 4, 6)}");
        }
        // 7
        public void LINQTest()
        {
            int[] nums = {20, - 5, 15, 10, 25 };

            Console.WriteLine("Numbers:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "\t");
            }

            bool allPositive = nums.All(n => n > 0);
            bool anyGreaterThan20 = nums.Any(n => n > 20);

            Console.WriteLine($"\nAll numbers are positive: {allPositive}");
            Console.WriteLine($"Any number greater than 20: {anyGreaterThan20}");
        }


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
    static class ArrayExtensions
    {
        public static void Fill<T>(T value, T[] arr, int left, int right)
        {
            if (arr == null)
            {
                throw new ArgumentNullException(nameof(arr), "Array cannot be null.");
            }

            if (left < 0 || right > arr.Length || left > right)
            {
                throw new ArgumentOutOfRangeException(nameof(left));
            }


            for (int i = left; i < right; i++)
            {
                arr[i] = value;
            }
        }
        public static T[] Join<T>(T[] arr1, T[] arr2)
        {
            if (arr1 == null || arr2 == null)
            {
                throw new ArgumentNullException("Arrays cannot be null.");
            }
        
            int length = arr1.Length + arr2.Length;
            T[] result = new T[length];
            Array.Copy(arr1, 0, result, 0, arr1.Length);
            Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
            return result;

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
            Console.WriteLine("\nTask 3:");
            try
            {
                double avg = task1.AverageDouble(1.0, 2.0, 3.0);
                Console.WriteLine($"Geometric mean: {avg}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\nTask 4:");
            task1.Distance();
            task5.Length(100);
            task5.FillArray();
            Console.WriteLine("\nTask 5,6:");
            task5.PrintArray();
            task5.FirstIndexOfZero();
            Console.WriteLine("\nTask 7:");
            task1.LINQTest();

        }
    }

}