using System;
using System.Collections.Generic;
//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the Selection sort algorithm: 
//Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.
class Program
{
    static void Main()
    {
       //int[] arrey = { 6, 29, 18, 29, 18, 19, 7, 16, 1, 3, 4, 5, 8, 0, 21, 1, 23, 23, 4,
       //                  24, 3, 12, 23, 17, 27, 25, 25, 11, 18,};

        Console.Write("Enter length of the arrey: ");           //
                                                                //
        int length = int.Parse(Console.ReadLine());             //
        int[] arrey = new int[length];                          //to test with the example above!!!
                                                                //you can comment this part and uncoment the part above
        for (int i = 0; i < length; i++)                        //
        {                                                       //
            Console.Write("Element {0} = ", i + 1);             //
            arrey[i] = int.Parse(Console.ReadLine());           //
        }                                                       //
                                                                //
        int temp = 0;

        for (int i = 0; i < arrey.Length; i++)
        {
            for (int j = i; j < arrey.Length; j++)
            {
                if (arrey[j]<arrey[i])
                {
                    temp = arrey[i];
                    arrey[i] = arrey[j];
                    arrey[j] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(",",arrey));
             
    }
}

