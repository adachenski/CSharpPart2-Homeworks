using System;
using System.Collections.Generic;
//Write a program that allocates array of 20 
//integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
class Program
{
    static void Main()
    {
        int[] arrey = new int[20];
        for (int i = 0; i < arrey.Length; i++)
        {
            arrey[i] = (i+1) * 5;
        }
        Console.WriteLine(string.Join(" ",arrey));
    }
}

