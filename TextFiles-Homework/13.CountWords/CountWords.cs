using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a list of words from the file words.txt 
//and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be 
//sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.
namespace _13.CountWords
{
    class CountWords
    {
        static void Main()
        {
            try
            {
                StreamReader forbidenWords = new StreamReader(@"../../words.txt");
                string[] readForbidenWords = forbidenWords.ReadToEnd().ToString()
                    .Split(new string[] { " ", ",", "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                forbidenWords.Close();

                StreamReader sr = new StreamReader(@"../../test.txt");
                string readInputText = sr.ReadLine();
                StreamWriter sw = new StreamWriter(@"../../result.txt");
                Dictionary<string,int> dic = ExtractForbiddenWordFromText(readForbidenWords, sr, ref readInputText);
                sr.Close();

                var list = dic.Keys.ToList();
                list.Sort();
                foreach (var key in list)
                {
                    Console.WriteLine("{0}: {1}", key, dic[key]);
                    sw.Write("{0}: {1}", key, dic[key]);
                    sw.Write("\r\n");
                }
                sw.Close();
  
            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine("Please check the path of your files: \r\n{0}", ex.Message);
            }
        }
        private static Dictionary<string, int> ExtractForbiddenWordFromText(string[] readForbidenWords, 
            StreamReader sr, ref string readInputText)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            while (readInputText != null)
            {
                if (readInputText != null)
                {
                    if (readInputText != null)
                    {
                        string readToString = readInputText.ToString();
                        string[] currentLineWords = readToString
                                                  .Split(new string[] { "-"," ", ",", "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                                                  .ToArray();
                       

                        for (int i = 0; i < readForbidenWords.Length; i++)
                        {
                            string currentWord = readForbidenWords[i];
                            int count = 0;
                            for (int j = 0; j < currentLineWords.Length; j++)
                            {
                                if (currentWord==currentLineWords[j])
                                {
                                    ++count;
                                }
                            }
                            if (dictionary.ContainsKey(currentWord))
                            {
                                dictionary[currentWord] += count;
                            }
                            else
                            {
                                dictionary.Add(currentWord, count);
                            }
                        }
                    }
                    readInputText = sr.ReadLine();
                }
            }
            return dictionary;
        }
    }
}
