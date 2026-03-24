using System;

namespace Lab3
{
    class Task1
    {
        private const int Width = 10;
        private const int Height = 5;

        public int[,] CreateArray()
        {
            int[,] array = new int[Width, Height];
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, 0] = random.Next(0, 100);
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    array[i, j] = array[i, j - 1] + random.Next(0, 100);
                }
            }

            return array;
        }

        public void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void MoveBiggestElementToLowerLeft(int[,] array)
        {
            int maxRow = 0;
            int maxCol = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > array[maxRow, maxCol])
                    {
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            int targetRow = array.GetLength(0) - 1; // lower row
            int targetCol = 0; // left column

            SwapRows(array, maxRow, targetRow);
            if (maxCol == targetCol)
            {
                return;
            }

            SwapColumns(array, maxCol, targetCol);
        }

        private static void SwapRows(int[,] array, int rowA, int rowB)
        {
            if (rowA == rowB)
            {
                return;
            }

            for (int col = 0; col < array.GetLength(1); col++)
            {
                (array[rowA, col], array[rowB, col]) = (array[rowB, col], array[rowA, col]);
            }
        }

        private static void SwapColumns(int[,] array, int colA, int colB)
        {
            if (colA == colB)
            {
                return;
            }

            for (int row = 0; row < array.GetLength(0); row++)
            {
                (array[row, colA], array[row, colB]) = (array[row, colB], array[row, colA]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();

            int[,] array = task1.CreateArray();
            Console.WriteLine("Original array:");
            task1.PrintArray(array);

            task1.MoveBiggestElementToLowerLeft(array);
            Console.WriteLine("\nArray after moving max element to lower-left corner:");
            task1.PrintArray(array);
        }
    }
}
