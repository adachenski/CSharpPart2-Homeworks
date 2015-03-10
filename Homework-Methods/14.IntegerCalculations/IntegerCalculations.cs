using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
//Write methods to calculate minimum, maximum, average, 
//sum and product of given set of integer numbers.
//Use variable number of arguments.

namespace _14.IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            CalculatingMinimum(numbers);
            CalculatingMaximum(numbers);
            CalculatingAverige(numbers);
            CalculatingProduct(numbers);
            CalculatingSum(numbers);

        }
        static int CalculatingMinimum(int[]arrey)
        {
            int min = arrey[0];
            for (int i = 1; i < arrey.Length; i++)
            {
                if (arrey[i]<min)
                {
                    min = arrey[i];
                }
            }
            Console.WriteLine("Min number is: {0}",min);
            return min;
        }
        static long CalculatingMaximum(int[] arrey)
        {
            long max = arrey[0];
            for (int i = 1; i < arrey.Length; i++)
            {
                if (arrey[i] > max)
                {
                    max = arrey[i];
                }
            }
            Console.WriteLine("Max number is : {0}",max);
            return max;
        }
        static double CalculatingAverige(int[] arrey)
        {
            int sum = 0;
            int i = 0;
            for (; i < arrey.Length; i++)
            {
                sum += arrey[i];
            }
            double Averige = sum/i;
            Console.WriteLine("Averige is : {0}", Averige);
            return Averige;
        }
        static int CalculatingSum(int[] arrey)
        {
            int sum = 0;
            for (int i = 1; i < arrey.Length; i++)
            {
                sum += arrey[i];
            }
            Console.WriteLine("The sum is : {0}", sum);
            return sum;
        }
        static BigInteger CalculatingProduct(int[] arrey)
        {
            BigInteger product = 1;
            for (int i = 1; i < arrey.Length; i++)
            {
                product *= arrey[i];
            }
            Console.WriteLine("Max Product is : {0}", product);
            return product;
        }
    }
}
