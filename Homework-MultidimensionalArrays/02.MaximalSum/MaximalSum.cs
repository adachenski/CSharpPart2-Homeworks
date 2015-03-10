using System;
using System.Collections.Generic;
//Write a program that reads a rectangular matrix of 
//size N x M and finds in it the square 3 x 3 that 
//has maximal sum of its elements.
namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            Console.Write("Enter N (rows) =: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Enter M (cols) =: ");
            int c = int.Parse(Console.ReadLine());

            int[,] matrix = new int[r, c];

            int sum = 0;
            int totalSum = 0;
            int colsStart = 0;
            int colsEnd = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = int.Parse(Console.ReadLine());
                }
            }

            //int[,] matrix = {
            //                     {7, 1, 3, 3, 2, 1},
            //                     {1, 3, 9, 8, 5, 6},
            //                     {4, 6, 7, 9, 1, 0} 
            //                };


            for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
            {

                for (int cols = 0; cols < matrix.GetLength(1) - 2; cols++)
                {

                    sum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2]
                    + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols + 2]
                     + matrix[rows + 2, cols] + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols + 2];
                    if (sum > totalSum)
                    {
                        totalSum = sum;
                        colsStart = cols;
                        colsEnd = colsStart + 2;
                    }
                }

            }
            Console.WriteLine("The biggest 3x3 platform is: ");
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (cols >= colsStart && cols <= colsEnd)
                    {
                        Console.Write("{0,4}", matrix[rows, cols]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("The sum of it's numbers is: " + totalSum);

        }
    }
}
