using System;
using System.Collections.Generic;
//Write a program that finds the index of given element in a 
//sorted array of integers by using the Binary search algorithm.
namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int[] arrey = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 11, 12, 16, 17, 18, 19, 21, 23, 24, 25, 27, 29 };
            Console.WriteLine(string.Join(" ",arrey));

            int start = arrey[0];
            int end = arrey.Length - 1;
            Console.Write("Find a number from the arrey above : ");

            int x =int.Parse(Console.ReadLine());

            while (true)
            {
                if (x==arrey[start]||x==arrey[end])
                {
                     Console.WriteLine("{0} is found!!!", x);
                     return;
                }
                int middle = (start + end) / 2;
                if (x < arrey[middle])
                {
                    end = middle;
                }
                else if (x > arrey[middle])
                {
                   start = middle;
                }
                if (x == arrey[middle])
                {
                    Console.WriteLine("{0} is found!!!", x);
                    return;
                }
                if (start==end-1)
                {
                    Console.WriteLine("Not found :(");
                    return;
                }
            }
        }
    }
}
