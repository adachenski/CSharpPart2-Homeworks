using System;
using System.Collections.Generic;
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
namespace _06.MaximalKSum
{
    class MaximalKSum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K = ");
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            int theBiggestSum = 0;
            //initalize the arrey with N elements
            int[] arrey = new int[n];
            //reading the arrey
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0} of {1}: ",i+1,n);
                arrey[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arrey);
            Console.Write("The biggest {0} numbers are :",k);
            for (int i = arrey.Length - 1; i >= 0; i--)
            {
                if (k>0)
                {
                    sum = arrey[i];
                    Console.Write(sum+",");
                    theBiggestSum += arrey[i];
                }
                --k;
               
            }
            Console.WriteLine("The biggest sum is: "+theBiggestSum);
           

        }
    }
}
