using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that compares two text files line by line 
//and prints the number of lines that are the same and the 
//number of lines that are different.
//Assume the files have equal number of lines
namespace _04.CompareTextFiles
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"..\..\LoremIpsum.txt");
            StreamReader sr2 = new StreamReader(@"..\..\LoremIpsum2.txt");
            string readFirst = sr.ReadLine();
            string readSecond = sr2.ReadLine();
            int count = 0;
            using (sr)
            {
                using (sr2)
                {
                    while (readFirst!=null)
                    {
                        int compare = readFirst.CompareTo(readSecond);
                        if (compare==0)
                        {
                            ++count;
                        }
                        readFirst = sr.ReadLine();
                        readSecond = sr2.ReadLine();
                    }
                }
            }
            Console.WriteLine("We have {0} lines that a equal! ",count);
          
        }
    }
}
