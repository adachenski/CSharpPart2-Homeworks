using System;
using System.Collections.Generic;
using System.Linq;
//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several 
//neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
namespace _03.SequenceNMatrix
{
    class Program
    {
        static void Main()
        {
            string[,] matrix ={
                                 {"6","3","3","4","5"},
                                 {"5","6","3","3","9"},
                                 {"7","5","2","3","8"},
                                 {"9","6","6","6","3"},
                                 {"7","8","9","9","6"},
                               };

           
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
    
                   
                }

            }
            //int temp = horizontal > vertical ? horizontal : vertical;
            //int result = sideWays > temp ? sideWays : temp;
           
                            Console.WriteLine(countHorizontalMax);
                            Console.WriteLine(horizontal);
        }
    }

}
