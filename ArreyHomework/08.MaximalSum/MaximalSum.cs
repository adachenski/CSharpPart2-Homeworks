using System;
using System.Collections.Generic;
//Write a program that finds the sequence of maximal sum in given array.
namespace _08.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            //int[] arrey = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };//find the maximal sum: 2, -1, 6, 4

            Console.Write("Enter length of the arrey: ");    //
                                                             //
            int length = int.Parse(Console.ReadLine());      //
            int[] arrey = new int[length];                   //to test with the default example above!!!
                                                             //you can comment this part and uncoment the part above
            for (int i = 0; i < length; i++)                 //
            {                                                //
                Console.Write("Element {0} = ", i + 1);      //
                arrey[i] = int.Parse(Console.ReadLine());    //
            }                                                //
                                                             //
            int sum=0, totalSum=0;
            int start = 0, finalStart = 0, stop=0;

            for (int i = 0; i < arrey.Length; i++)
            {
                for (int j = i; j < arrey.Length; j++)
                {
                    sum = sum + arrey[j];
                    if (j==i)
                    {
                        start = j;
                    }
                    
                    if (sum>totalSum)
                    {
                        totalSum = sum;
                        finalStart = start;
                        stop = j;
                    }
                }
                sum = 0;
            }

            for (int i = finalStart; i <= stop; i++)
            {
                Console.Write(arrey[i]+" ");
            }
        }
    }
}
