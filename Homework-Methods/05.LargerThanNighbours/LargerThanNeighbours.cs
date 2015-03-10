using System;
using System.Collections.Generic;
using System.Linq;
//Write a method that checks if the element at given 
//position in given array of integers is larger than
//its two neighbours (when such exist).
namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            Console.WriteLine("Enter your numbers separated by comma ");
            int[] arrey = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            Console.WriteLine("Please pick a position to compare");
            int myChoice = int.Parse(Console.ReadLine());
            LargerThanNeighbour(arrey, myChoice);
        }

        static void LargerThanNeighbour(int[] arrey, int position)
        {
            bool isBigger = false;
            for (int i = 0; i < arrey.Length; i++)
            {
                if (i == position && i == 0)
                {
                    if (arrey[position] > arrey[i + 1])
                    {
                        isBigger = true;
                        Console.WriteLine(isBigger);
                    }
                    else
                    {
                        Console.WriteLine(isBigger);
                    }
                    break;
                }
                if (i > 0 && i < arrey.Length - 1)
                {
                    if (position == i)
                    {
                        if (arrey[position] > arrey[i - 1] && arrey[position] > arrey[i + 1])
                        {
                            isBigger = true;
                            Console.WriteLine(isBigger);
                        }
                        else
                        {
                            Console.WriteLine(isBigger);
                        }
                        break;
                    }

                }
                if (arrey[i] == arrey[arrey.Length - 1])
                {
                    if (position > arrey[i - 1])
                    {
                        isBigger = true;
                        Console.WriteLine(isBigger);
                    }
                    else
                    {
                        Console.WriteLine(isBigger);
                    }
                    break;
                }

            }
        }
    }
}
