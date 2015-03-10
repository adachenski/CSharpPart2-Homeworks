using System;
using System.Collections.Generic;
using System.Linq;
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
namespace AppearanceCount
{
    class ApperanceCount
    {
        static void Main()
        {
            Console.WriteLine("Enter your numbers on One line separated by comma");
            int[] numbers = Console.ReadLine()
               .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x))
               .ToArray();
            Console.WriteLine("Enter the number you're searching for");
            int n = int.Parse(Console.ReadLine());
            TheMostFrequentNumber(numbers, n);
        }
        static void TheMostFrequentNumber(int[] numbers, int n)
        {

            int count = 0;
            int current = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (n == numbers[i])
                {
                    count++;
                    current = numbers[i];
                }
            }
            PrintNumbers(current, count);
        }
        static void PrintNumbers(int current, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(current);
                if (i < count-1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }


    }
}
