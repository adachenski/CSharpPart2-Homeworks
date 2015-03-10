using System;
using System.Collections.Generic;
using System.Linq;
//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
namespace _09.SortingArray
{
    class SortingArray
    {
        static void Main()
        {
            //int[] array = new int[] { 23, 2, 3, 454, 56, 42, 38, 7, 54, 3, 12, 36 };
            Console.WriteLine("Enter your numbers on one line separated by comma !!!"
                +"\nthan Press Enter!!!");
            int[] array = Console.ReadLine()
               .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x))
               .ToArray();
             
            int[] result = TakePartOfTheArray(array);
            OrderFromTopToBottom(result);
           

        }
        static void OrderFromTopToBottom(int[]arr)
        {
            Console.WriteLine("Sorted in ascending-descending order:");
            var result = arr.OrderByDescending(n => n);
            Console.WriteLine(string.Join(",",result));
        }
        static int[] TakePartOfTheArray(int[] arr)
        {
            Console.WriteLine("Enter number betwen {0} and {1}",0,arr.Length-1);
            Console.Write("Start = ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number less than {0}",arr.Length);
            Console.Write("Start = ");
            int end = int.Parse(Console.ReadLine());

            int lenght = end - start;
            int[] result = new int[lenght + 1];


            for (int i = start; i <= end; i++)
            {
                result[i - start] = arr[i];
            }
            Console.WriteLine("Your custom array is: ");
            Console.WriteLine(string.Join(",", result));
            return result;
        }
    }
}
