using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that extracts from given XML file all the text without the tags.
namespace _10.ExtractTextFromXML
{
    class TextFromXML
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"../../input.xml");
            StreamWriter sw = new StreamWriter(@"../../result.txt");
            string readInput = sr.ReadLine();
            while (readInput!=null)
            {
                
                if (readInput!=null)
                {
                    string inputToString = readInput.ToString();
                    for (int i = 0; i < inputToString.Length; i++)
                    {
                        char curent = inputToString[i];
                        if (curent=='<')
                        {
                            i = FindingClosingBracket(inputToString, i);
                        }
                        else
                        {                           
                            if (i==inputToString.Length-1)
                            {
                                break;
                            }
                            sw.Write(inputToString[i]);
                            if (inputToString[i+1]=='<')
                            {
                                sw.Write("\r\n");
                            }
                        }
                    }
                }

                readInput = sr.ReadLine();
            }

            sr.Close();
            sw.Close();
        }

        private static int FindingClosingBracket(string temp, int i)
        {
            for (int j = i; j < temp.Length; j++)
            {
                char current2 = temp[j];
                if (current2 == '>')
                {
                    i = j;
                    break;
                }
            }
            return i;
        }
    }
}
