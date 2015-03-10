using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. 
//Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.
namespace _08.ExtractSentences
{
    class ExtractSentence
    {
        static void Main()
        {
            string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine"
                + "is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            int count = 0;
            while (count<=input.Length)
            {
                int temp2 = input.Length;
                int first = input.IndexOf(". ",count);
                if (first<0)
                {
                    first = input.Length;
                }
                int temp = first - count;
                string oneSentance = input.Substring(count, temp);
                int check = oneSentance.IndexOf(" in ");
                if (check>0)
                {
                    Console.WriteLine(oneSentance);
                }               
                count = first+1;
            }
        }
    }
}
