using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a text file and inserts 
//line numbers in front of each of its lines.
//The result should be written to another text file.
namespace _03.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"..\..\LoremIpsum.txt");
            
            using (sr)
            {
                string readText = sr.ReadLine();
                int count = 1;
                StreamWriter sw = new StreamWriter(@"..\..\someText.txt");
                while (readText != null)
                {
                     sw.WriteLine("{0} {1}", count, readText);
                     readText = sr.ReadLine();
                     ++count;
                }
                sw.Close();
            }
        }
    }
}
