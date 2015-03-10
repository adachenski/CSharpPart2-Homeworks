using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a string from the console and lists all 
//different words in the string along with information 
//how many times each word is found.
namespace _22.WordsCount
{
    class WordsCount
    {
        static void Main()
        {
            string input = "Write all program that reads all string from thein  console and prints all "
            + "letters in the string in along with and in how reads many times each letter all found.";
            char[] separators = new char[] {' ', ',', '.'};
            string[] inputArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<string> counedLetters = new List<string>();
            List<int> countedNumbers = new List<int>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool found = true;
                for (int k = 0; k < counedLetters.Count; k++)
                {
                    if (inputArray[i] == counedLetters[k])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    int count = 0;
                    for (int j = i + 1; j < inputArray.Length; j++)
                    {
                        if (inputArray[j] == inputArray[i])
                        {
                            ++count;
                        }
                        if (j == inputArray.Length-1)
                        {
                            countedNumbers.Add(count + 1);
                            counedLetters.Add(inputArray[i]);
                        }
                    }
                }
            }
            for (int i = 0; i < counedLetters.Count; i++)
            {
                Console.WriteLine("{0} - {1} times ", counedLetters[i], countedNumbers[i]);
            }
        }
    }
}
