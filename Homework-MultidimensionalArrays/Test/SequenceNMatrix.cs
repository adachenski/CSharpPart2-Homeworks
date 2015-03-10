using System;
using System.Collections.Generic;
//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several 
//neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix
namespace Test
{
    class SequenceNMatrix
    {
        static void Main(string[] args)
        {
            //string[,] matrix ={
            //                     {"3","4","3","2","k"},
            //                     {"1","ma","1","1","k"},
            //                     {"4","2","ma","9","15"},
            //                     {"1","4","3","ma","19"},
            //                     {"1","ko","4","kx","ma"},
            //                   };

            //string[,] matrix ={
            //                     {"s","qq","s"},
            //                     {"pp","pp","s"},
            //                     {"pp","qq","s"},
            //                   };

            string[,] matrix ={
                                 {"ha","fifi","ho","hi"},
                                 {"fo","ha","hi","xx"},
                                 {"xxx","ho","ha","xx"},
                               };
            
            int countVertical = 0;
            int countVerticalMax = 0;
            string verticalString = string.Empty;
            int countSideWays = 0;
            string sideWayString = string.Empty;
            int countSideWaysMax = 0;
            int countHorizontal = 0;
            int countHorizontalMax = 0;
            string horizontalString = string.Empty;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                countVertical = row;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == 0)//checking for vertical neibor elements
                    {
                        for (int k = 0; k < matrix.GetLength(0) - 1; k++)
                        {
                            if (matrix[k, col] == matrix[k + 1, col])
                            {
                                countVertical++;
                            }
                            if (countVerticalMax<countVertical)
                            {
                                countVerticalMax = countVertical;
                                verticalString = matrix[k, col];
                            }
                            if (matrix[k, col] != matrix[k + 1, col])
                            {
                                countVertical=0;
                            }

                        }
                        countVertical = 0;
                    }
                    if (col <= matrix.GetLength(0) - 1)//checking for neibor elements sideWays
                    {
                        for (int i = 0; i < matrix.GetLength(0) - 1 - row; i++)
                        {
                            if (i + col + row >= matrix.GetLength(0) - 1)
                            {
                                break;
                            }

                            if (matrix[i + row, col + i] == matrix[i + row + 1, col + i + 1])
                            {
                                countSideWays++;
                            }
                            if (countSideWaysMax < countSideWays)
                            {
                                countSideWaysMax = countSideWays;
                                sideWayString = matrix[i + row, col + i];
                            }
                            if (matrix[i + row, col + i] != matrix[i + row + 1, col + i + 1])
                            {
                                countSideWays = 0;
                            }
                        }
                        countSideWays = 0;
                    }
                    if (col == 0)//checking for horizontal neibors
                    {
                        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
                        {
                            if (matrix[row, i] == matrix[row, i + 1])
                            {
                                countHorizontal++;
                            }
                            if (countHorizontalMax < countHorizontal)
                            {
                                countHorizontalMax = countHorizontal;
                                horizontalString = matrix[row, i];
                            }
                            if (matrix[row, i] != matrix[row, i + 1])
                            {
                                countHorizontal = 0;
                            }
                        }
                        countHorizontal = 0;
                    }
                    
                }
             
            }
            //calculating the biggest element 
            int a = countHorizontalMax;
            int b = countSideWaysMax;
            int c = countVerticalMax;
            int temp = a > b ? a : b;
            int result = c > temp ? c : temp;

            if (countHorizontalMax==result)
            {
                for (int i = 0; i <= countHorizontalMax; i++)
                {
                    Console.Write(horizontalString);
                    if (i<countHorizontalMax)
                    {
                        Console.Write(',');
                    }
                }
            }
            if (countVerticalMax == result)
            {
                for (int i = 0; i <= countVerticalMax; i++)
                {
                    Console.Write(verticalString);
                    if (i < countVerticalMax)
                    {
                        Console.Write(',');
                    }
                }
            }
            if (countSideWaysMax == result)
            {
                for (int i = 0; i <= countSideWaysMax; i++)
                {
                    Console.Write(sideWayString);
                    if (i < countSideWaysMax)
                    {
                        Console.Write(',');
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
