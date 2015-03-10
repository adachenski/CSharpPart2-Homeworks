using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
namespace _03.CorrectBrackets
{
    class CorectBracets
    {
        static void Main()
        {
            string input = "((a+b)(/5)-d)";
            int count = 0;
           
      
            bool open = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[0] == ')')
                {
                    Console.WriteLine("Brackets NOT put corectly !!!");
                    open = false;
                    break;
                }
                if (input[i] == '(')
                {
                    if (count==0)
                    {
                        open = false;
                    }
                 
                    count++;
                }
                if (input[i] == ')')
                {
                    count--;
                    if (count==0)
                    {
                        open = true;
                    }
                    if (count<0)
                    {
                        open = false;
                    }
                }
            }
            Console.WriteLine(open);
        }
    }
}
