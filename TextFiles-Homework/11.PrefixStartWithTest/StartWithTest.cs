using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.
namespace _11.PrefixStartWithTest
{
    class StartWithTest
    {
       
        private static StreamWriter sw = new StreamWriter(@"../../output.txt");
        static void Main()
        {
            StreamReader sr = new StreamReader(@"../../input.txt");
            
            string findingTest = " test";
            string readFromInput = sr.ReadLine().ToString();
            int count = 0;

            ExtractingWordsFromALine(ref findingTest, readFromInput, ref count);
            sw.Write("\r\n");

            while (readFromInput!=null)
            {
                
                readFromInput = sr.ReadLine();
                if (readFromInput!=null)
                {
                    findingTest = "";
                    string inputToString = readFromInput.ToString();
                    count = 0;
                    ExtractingWordsFromALine(ref findingTest, inputToString, ref count);
                    sw.Write("\r\n");
                }
                
            }
             

            sr.Close();
            sw.Close();
        }

        private static void ExtractingWordsFromALine(ref string findingTest, string readFromInput, ref int count)
        {
            while (count < readFromInput.Length)
            {
                int startIndex = readFromInput.IndexOf(" test", count);

                if (startIndex < 0)
                {
                    sw.Write(readFromInput.Substring(count, readFromInput.Length - count));
                    findingTest = " test";
                    //sw.Flush();
                    break;
                }
                sw.Write(readFromInput.Substring(count, startIndex - count));
                findingTest = " test";
                //sw.Flush();
                for (int i = startIndex + findingTest.Length; i < readFromInput.Length; i++)
                {
                    char start = readFromInput[i];
                    if (start == ' ')
                    {
                         count = startIndex + findingTest.Length;
                        break;
                    }
                    if (start >= '0' && start <= '9'
                        || start >= 'a' && start <= 'z'
                        || start >= 'A' && start <= 'Z'
                        || start =='_')
                    {
                       findingTest += readFromInput[i];
                    }
                    else
                    {
                        sw.Write(' ');
                        count = startIndex + 1;
                        break;
                    }
                }
            }
        }
    }
}
