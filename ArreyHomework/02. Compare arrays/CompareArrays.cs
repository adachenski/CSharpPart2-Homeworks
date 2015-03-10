using System;
using System.Collections.Generic;
//Write a program that reads two integer arrays 
//from the console and compares them element by element.
class CompareArrays
{
    static void Main()
    {
        Console.Write("Choose lenght of the arrey: ");
        int lenght = int.Parse(Console.ReadLine());
        int[] arrey1 = new int[lenght];
        int[] arrey2 = new int[lenght];
        //filling the arrey number 1
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Arrey1 element {0}= ",i+1);
            arrey1[i] =int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        //filling the arrey number 2
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Arrey2 element {0}= ", i + 1);
            arrey2[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        //printing the result 
        for (int i = 0; i < lenght; i++)
        {
            if (arrey1[i]>arrey2[i])
            {
                Console.WriteLine(arrey1[i]+">"+arrey2[i]);
            }
            if (arrey1[i] < arrey2[i])
            {
                Console.WriteLine(arrey1[i] + "<" + arrey2[i]);
            }
            if (arrey1[i] == arrey2[i])
            {
                Console.WriteLine(arrey1[i] + "=" + arrey2[i]);
            }
        }

    }
}

