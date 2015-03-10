using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that extracts from given HTML 
//file its title (if available), and its body 
//text without the HTML tags
namespace _25.ExtractTextFromHTML
{
    class TextFromHtml
    {
        static void Main()
        {
            StreamReader streamReader = new StreamReader(@"..\..\testing.txt");
            string text = streamReader.ReadToEnd().ToString();
            Console.WriteLine(text);
            StringBuilder extractHtml = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='<')
                {
                    for (int j = i; j < text.Length; j++)
                    {
                        if (text[j]=='>')
                        {
                            i = j;
                            break;
                        }
                    }
                }
                else
                {
                    extractHtml.Append(text[i]);
                }
            }
            Console.WriteLine(extractHtml);
        }
    }
}
