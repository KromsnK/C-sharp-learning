using System;
using System.Buffers;

namespace Lab3
{
    class Task1
    {
        int width = 10;
        int height = 5;

        public int CreateArray(int[,] a)
        {
            int[,] array = new int[width,height];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i,0] = random.Next(0, 100);
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    array[i,j] = array[i,j-1] + random.Next(0, 100);
                }
            }
            return array[width,height];
        }
        public void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void BiggestElement(int[,] array)
        {
            // left lower corner
            int temp = array[0, 0],maxCols=0,maxRows=0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
           
            task1.CreateArray();
        }
    }
}