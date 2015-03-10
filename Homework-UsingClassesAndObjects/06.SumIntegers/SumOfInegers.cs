using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
namespace _06.SumIntegers
{
    class SumOfInegers
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            long result = SumOfNumbers(numbers);
            Console.WriteLine("The sum ot the numbers above is : {0}",result);
        }
        static long SumOfNumbers(int []numbers)
        {
            long result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
                return result;
        }
    }
}
