using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that replaces all occurrences of the 
//sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).
namespace _07.Replace_sub_string
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"..\..\LoremIpsum.txt");
            string read = sr.ReadLine();
            string readToString = read.ToString();
            string replace = readToString.Replace("start", "finish");
            // Console.WriteLine(replace);
            StreamWriter sw = new StreamWriter("result.txt");
            sw.Write(replace);
            while (read != null)
            {
                read = sr.ReadLine();
                if (read != null)
                {
                    readToString = read.ToString();
                    replace = readToString.Replace("start", "finish");
                    sw.Write(replace);
                    sw.Write("\r\n");
                    //Console.WriteLine(replace);

                }

            }

            sr.Close();
            sw.Close();
        }
    }
}
