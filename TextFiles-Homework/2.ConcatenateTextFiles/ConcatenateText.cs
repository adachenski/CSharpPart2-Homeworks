using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Write a program that concatenates two text files into another text file.
namespace _2.ConcatenateTextFiles
{
    class ConcatenateText
    {
        static void Main()
        {
            StreamReader firstSR = new StreamReader(@"../../LoremIpsum.txt");
            StreamReader secondSR = new StreamReader(@"../../AnotherText.txt");

            using (firstSR)
            {
                using (secondSR)
                {
                    string readFirst = firstSR.ReadToEnd();
                    string readSecond = secondSR.ReadToEnd();
                    string third = String.Concat(readFirst, readSecond);
                    StreamWriter writeThird = new StreamWriter(@"../../ThirdText.txt");
                    writeThird.Write(third);
                    writeThird.Close();
                }
            }
        }
    }
}
