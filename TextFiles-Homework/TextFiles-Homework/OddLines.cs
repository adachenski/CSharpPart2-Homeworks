using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a text file and prints on the console its odd lines.
namespace TextFiles_Homework
{
    class OddLines
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"..\..\LoremIpsum.txt");
           
            using (sr)
            {
                int count = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine("Line {0}: {1}", count, line);
                    }                    
                    ++count;
                    line = sr.ReadLine();
                }
            }
        }
    }
}
