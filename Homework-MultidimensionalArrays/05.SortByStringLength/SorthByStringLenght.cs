using System;
using System.Linq;
//You are given an array of strings. Write a method that sorts the 
//array by the length of its elements (the number of characters composing them).
namespace _05.SortByStringLength
{
    class SorthByStringLenght
    {
        static void Main()
        {
            //enter words separated by coma
            Console.Write("Please enter words, \nseparated by comma : ");
            string[] arrey = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => (x))
                .ToArray();

            string temp = String.Empty;

            for (int i = 0; i < arrey.Length; i++)
            {
                for (int j = i+1; j < arrey.Length; j++)
                {
                    if (arrey[i].Length > arrey[j].Length)
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
}
