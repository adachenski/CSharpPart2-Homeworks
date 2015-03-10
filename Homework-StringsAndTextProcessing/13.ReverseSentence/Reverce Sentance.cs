using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reverses the words in given sentence.
namespace _13.ReverseSentence
{
    class Program
    {
        static void Main()
        {
            string input = "C# is not C++, not PHP and not Delphi!";
            string temps = input;
            string inputMovedComas = "";
            int comma = 0;
            int count = 0; 
            while (comma!=-1)
            {
                comma = input.IndexOf(',',count);
                if (comma==-1)
                {
                    break;
                }
                
                inputMovedComas = input.Substring(0, comma);
                inputMovedComas += " ,";
                inputMovedComas += input.Substring(comma + 1);
                count = comma + 1;
            }
            input = inputMovedComas;
            char[] separators = new char[] { ' ', '.','!','?' };
            List<int> commasLocation = new List<int>();
            string[] beersArr = input.Split(separators);
            for (int i = 0; i < beersArr.Length; i++)
            {
                if (beersArr[i]==",")
                {
                    commasLocation.Add(i);
                }
            }
          
            char lastSymbol = input[input.Length-1];
            Array.Reverse(beersArr);
           // Console.WriteLine(string.Join(" ", beersArr));
            Console.WriteLine();
            for (int i = 0; i < beersArr.Length; i++)
            {
                int temp = 0;
                if (beersArr[i] == ",")
                {
                    continue;
                }
                Console.Write("{0}",beersArr[i]);
                if (i==commasLocation[temp])
                {
                    Console.Write(", ");
                    ++temp;
                }
                else
                {
                    if (i == beersArr.Length - 1)
                    {
                        Console.WriteLine(lastSymbol);
                        break;
                    }
                    Console.Write(" ");
                }               
            }
            Console.WriteLine();
        }
    }
}
