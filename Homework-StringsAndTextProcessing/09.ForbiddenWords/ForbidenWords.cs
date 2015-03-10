using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//We are given a string containing a list of forbidden words and a text containing 
//some of these words. Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. 
//It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Forbidden words: PHP, CLR, MicrosoftThe expected result: ********* announced its 
//next generation *** compiler today. It is based on .NET Framework 4.0 and is 
//implemented as a dynamic language in ***.
namespace _09.ForbiddenWords
{
    class ForbidenWords
    {
        static void Main()
        {
            string input = "Microsoft announced its next generation "
            + "PHP compiler today. It is based on .NET Framework 4.0 and "
            + "is implemented as a dynamic language in CLR.";

            string s1 = input.Replace("Microsoft","*********");
            string s2 = s1.Replace("PHP", "***");
            string result = s2.Replace("CLR", "***");
            Console.WriteLine(result);    
        }
    }
}
