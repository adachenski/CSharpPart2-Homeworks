using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
namespace _05.MaximalAreaSum
{
    class SumArea
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"..\..\matrix.txt");
            int size = int.Parse(sr.ReadLine());
            string matrix = sr.ReadLine();
            string temp = matrix.ToString();

            while (matrix!=null)
            {
                Console.WriteLine(matrix);
                matrix = sr.ReadLine();
                if (matrix!=null)
                {
                    temp += matrix.ToString();
                }
            }
            sr.Close();
           int [,]resultArray = FIllingTheMatrix(size, temp);
           int sum = Result(resultArray);
           Console.WriteLine(sum);
           StreamWriter result = new StreamWriter("result.txt");
           result.Write(sum.ToString());
           result.Close();
          
        }
        private static int Result(int [,]arraay)
        {
            int sum = 0;
            for (int i = 0; i < arraay.GetLength(0)-1; i++)
            {
                for (int j = 0; j < arraay.GetLength(1)-1; j++)
                {
                    int current = arraay[i, j]+arraay[i,j+1]
                        +arraay[i+1,j]+arraay[i+1,j+1];
                    if (sum<current)
                    {
                        sum = current;
                    }
                }
            }
            return sum;
        }
        private static int[,] FIllingTheMatrix(int size, string temp)
        {
            int[] numbers = temp
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int[,] result = new int[size, size];
            int count = 0;
            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {

                    result[row, col] = numbers[count];
                    ++count;
                }
            }
            return result;
        }
    }
}
