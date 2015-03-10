using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that removes from a 
//text file all words listed in given another text file.
//Handle all possible exceptions in your methods.
namespace _12.RemoveWords
{
    class RemoveWords
    {
        static void Main()
        {        
            try
            {
                StreamReader forbidenWords = new StreamReader(@"../../ForbidenWords.txt");
                string[] readForbidenWords = forbidenWords.ReadToEnd().ToString()
                    .Split(new string[] { " ", ",", "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                forbidenWords.Close();

                StreamReader sr = new StreamReader(@"../../InputText.txt");
                string readInputText = sr.ReadLine();
                StreamWriter sw = ExtractForbiddenWordFromText(readForbidenWords, sr, ref readInputText);
                sr.Close();
                sw.Close();
            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine("Please check the path of your files: \r\n{0}",ex.Message);
            }
           
        }

        private static StreamWriter ExtractForbiddenWordFromText(string[] readForbidenWords, StreamReader sr, ref string readInputText)
        {
            StreamWriter sw = new StreamWriter("output.txt");
            while (readInputText != null)
            {
                if (readInputText != null)
                {
                    if (readInputText != null)
                    {
                        string readToString = readInputText.ToString();
                        for (int i = 0; i < readForbidenWords.Length; i++)
                        {
                            int currentWord = readToString.IndexOf(readForbidenWords[i]);
                            string curentWordLenght = readForbidenWords[i];
                            if (currentWord < 0)
                            {
                                continue;
                            }
                            readToString = readToString.Remove(currentWord, curentWordLenght.Length);

                        }
                        sw.Write(readToString);
                        sw.Flush();
                        sw.Write("\r\n");
                    }

                    readInputText = sr.ReadLine();

                }

            }
            return sw;
        }
    }
}
