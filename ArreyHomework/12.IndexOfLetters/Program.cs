using System;
using System.Collections.Generic;
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

namespace _12.IndexOfLetters
{
    class Program
    {
        static void Main()
        {
            List<char> samllLeters = new List<char>();
            List<char> capitalLeters = new List<char>();
            //initializing small leters alphabet
            for (int i = 'a'; i <= 'z'; i++)
            {
                samllLeters.Add((char)i);
            }
            //initializing capital letters alphabet
            for (int i = 'A'; i <= 'Z'; i++)
            {
                capitalLeters.Add((char)i);
            }
            //convert list to charArrey
            char[] smallAlphabetSymbols = samllLeters.ToArray();
            char[] capitalAlphabetSymbols = capitalLeters.ToArray();
            Console.WriteLine(string.Join(",", smallAlphabetSymbols));
            Console.WriteLine(string.Join(",", capitalAlphabetSymbols));
            // pick up a word
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < smallAlphabetSymbols.Length; j++)
                {
                    if (word[i] == smallAlphabetSymbols[j]
                        || word[i] == capitalAlphabetSymbols[j])
                    {
                        Console.WriteLine("{0} = #{1}",word[i],j+1);
                        break;
                    }
                }
            }
        }
    }
}
