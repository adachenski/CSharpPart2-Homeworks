using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
namespace _20.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            //just some text with random palindrames in it.
            string text = "Whrite a program that reads a string from helleh the "
            + "console and prints all different boob."
            + "letters in the string axa along with information"
            + " how saas many times each letter is found.";

            char[] separators = new char[] { ' ', ',', '.' };
            //string[] beersArr = text.Split(separators);
            string[] beersArr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < beersArr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < beersArr[i].Length/2; j++)
                {
                    if (beersArr[i][j]==beersArr[i][beersArr[i].Length-1-j])
                    {
                        ++count;
                        if (count==beersArr[i].Length/2)
                        {
                            Console.Write("{0}, ",beersArr[i]);
                        }
                    }
                }              
            }
            Console.WriteLine();
        }
    }
}
