using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.
namespace _09.DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"..\..\LoremIpsum.txt");
            StreamWriter sw = new StreamWriter("resultOddLinesRemoved.txt");
            using (sr)
            {
                int count = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (count % 2 != 0)
                    {
                        sw.Write("\r\n");
                        
                    }
                    else
                    {
                        sw.Write("Line {0}: {1}", count, line);
                        //Console.WriteLine("Line {0}: {1}", count, line);
                    }
                    ++count;
                    line = sr.ReadLine();
                }
                sw.Close();
            }
            StreamReader sr2 = new StreamReader(@"..\..\bin\Debug\resultOddLinesRemoved.txt");
            StreamWriter sw2 = new StreamWriter(@"..\..\LoremIpsum.txt" );
            using (sr2)
            {
                string line = sr2.ReadLine();
                sw2.Write(line);
                while (line!=null)
                {
                    line = sr2.ReadLine();
                    if (line!=null)
                    {
                        sw2.Write(line);
                        sw2.Write("\r\n");
                    }

                }
            }
            sw2.Close();            
        }
    }
}
