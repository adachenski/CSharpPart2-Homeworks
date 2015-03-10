using System;
using System.Collections.Generic;
//Write a program that finds the maximal sequence of equal elements in an array.
class Program
{
    static void Main()
    {
        //int[] arrey = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        
        Console.Write("Enter length of the arrey: ");  //
                                                       //
        int length = int.Parse(Console.ReadLine());    //
        int[] arrey = new int[length];                 //to test with the default example above!!!
                                                       //you can comment this part and uncoment the part above
        for (int i = 0; i < length; i++)               //
        {                                              //
            Console.Write("Element {0} = ", i + 1);    //
            arrey[i] = int.Parse(Console.ReadLine());  //
        }                                              //
                                                       //
        int count = 0;
        int totalCount = 0;
        int cuttentNumber = 0;

        for (int i = 0; i < arrey.Length-1; i++)
        {
            if (arrey[i] == arrey[i+1])
            {
                count++;
            }
            else
            {
                count = 0;
            }
            if (count > totalCount)
            {
                totalCount = count;
                cuttentNumber = arrey[i];
            }
        }

        for (int i = 0; i <= totalCount; i++)
        {
            Console.Write(cuttentNumber);
            if (i<totalCount)
            {
                Console.Write(',');
            }
        }
        Console.WriteLine();
    }
}

