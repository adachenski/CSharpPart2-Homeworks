using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that finds how many times a sub-string is contained 
//in a given text (perform case insensitive search).
//Example: The target sub-string is in
//The text is as follows: We are living in an yellow submarine. 
//We don't have anything else. inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9
namespace _04.SubStringInText
{
    class Program
    {
        static void Main()
        {
            string text = " We are living in an yellow submarine. We don't have anything else. inside the submarine"
                + "is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            int index1 = text.IndexOf("in");
            int temp = 0;
            int count = 0;
            while (temp>=0)
            {
                index1 = text.IndexOf("in",temp);
                int index2 = text.IndexOf("in", index1+1);
                temp = index2;
                count++;
            }
            Console.WriteLine("The result is : {0}",count);
        }
    }
}
