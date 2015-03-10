using System;
using System.Collections.Generic;
using System.Linq;
//Write a method that returns the index of the first element in array that is 
//larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise. 
namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            int[] arrey = { 1, 2, 3, 51, 46, 47, 48, 48, 48 };//you can type any numbers in the array
            LargerThanNeighbour(arrey);
        }

        static void LargerThanNeighbour(int[] arrey)
        {
            for (int i = 0; i < arrey.Length; i++)
            {
                int element = arrey[i];
                if (element == arrey[0])
                {
                    if (element > arrey[i + 1])
                    {
                        Console.WriteLine(arrey[i]);
                        break;
                    }
                }
                if (i > 0 && i < arrey.Length - 1)
                {
                    if (element > arrey[i - 1] && element > arrey[i + 1])
                    {
                        Console.WriteLine(arrey[i]);
                        break;
                    }

                }
                if (arrey[i] == arrey[arrey.Length-1])
                {
                    if (element > arrey[i - 1])
                    {
                        Console.WriteLine(arrey[i]);
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                    break;
                }
            }
        }
    }
}
