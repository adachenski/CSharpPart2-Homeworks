using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//u are given a text. Write a program that changes the text in all regions surrounded 
//by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested. Example: We are living in a <upcase>yellow submarine</upcase>.
//We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
namespace _05.ParseTags
{
    class ParseTags
    {
        static void Main()
        {
             Console.Write("Enter Some TEXT : ");
             string text = Console.ReadLine();
             Console.ForegroundColor = ConsoleColor.Blue;
             Console.Write("Enter a START position = ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter a END position = ");
            int end = int.Parse(Console.ReadLine());
            int endSubstring = end -start;
            string textToUpper = text.Substring(start,endSubstring).ToUpper();
            string firstPrt = text.Substring(0, start);
            string secondPrt = text.Substring(end);
            Console.WriteLine(firstPrt+textToUpper+secondPrt);

        }
    }
}
