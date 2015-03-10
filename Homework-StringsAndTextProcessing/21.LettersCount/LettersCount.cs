using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a string from the console and prints 
//all different letters in the string along with information how 
//many times each letter is found.
namespace _21.LettersCount
{
    class LettersCount
    {
        static void Main()
        {
            string input = "Write a program that reads a string from the console and prints all "
            + "different letters in the string along with information how many times each letter is found.";

            StringBuilder counedLetters = new StringBuilder();
            List<int> countedNumbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                bool found = true;
                for (int k = 0; k < counedLetters.Length; k++)
                {
                    if (input[i] == counedLetters[k])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    int count = 0;
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (input[j] == input[i])
                        {
                            ++count;
                        }
                        if (j == input.Length - 1)
                        {
                            countedNumbers.Add(count+1);
                            counedLetters.Append(input[i]);
                        }
                    }
                }
            }
            for (int i = 0; i < counedLetters.Length; i++)
            {
                Console.WriteLine("{0} found {1} times ",counedLetters[i],countedNumbers[i]);
            }
        }
    }
}
