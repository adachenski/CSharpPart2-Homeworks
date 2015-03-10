using System;
using System.Collections.Generic;
//Write a program that finds in given array of 
//integers a sequence of given sum S (if present).
namespace _10.FindSumInArray
{
    class FindSumInArrey
    {
        static void Main()
        {
            //int[] arrey = { 4, 3, 1, 4, 2, 5, 8 };//result 4, 2, 5;
            Console.Write("Enter S = ");
            int sum = int.Parse(Console.ReadLine());

            Console.Write("Enter length of the arrey: ");

            int length =int.Parse(Console.ReadLine());
            int[] arrey = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Element {0} = ",i+1);
                arrey[i] = int.Parse(Console.ReadLine());
            }
            int temp = sum;
            int stop = 0,start=0, firstItem =0;

            for (int i = 0; i < arrey.Length; i++)
            {
                for (int j = i; j < arrey.Length; j++)
                {
                    temp = temp - arrey[j];
                    if (j==i)
                    {
                        firstItem = j; 
                    }
                    if (temp==0)
                    {
                        start = firstItem;
                        stop = arrey[j];
                        for (int k = start; k <= stop; k++)
                        {
                            Console.Write(arrey[k]+",");
                        }
                        Console.WriteLine();
                        return;
                    }
                }
                temp = 11;
            }
            Console.WriteLine(start);
            Console.WriteLine(stop);
        }
    }
}
