using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
namespace _14.WordDictionary
{
    class WordDictionary
    {
        static void Main()
        {
            Dictionary<string, string> translator = new Dictionary<string, string>();
            translator.Add(".NET", "platform for applications from Microsoft");
            translator.Add("CLR", "managed execution environment for .NET");
            translator.Add("namespace", "hierarchical organization of classes");
            Console.Write("Search for .NET, CLR or namespace :");
            string key = Console.ReadLine();

            if (translator.ContainsKey(key))
            {
                string value = translator[key];
                Console.WriteLine(value);
            }
        }
    }
}
