using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
namespace _06.SaveSortedNames
{
    class SaveStoredNames
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"..\..\input.txt");
            string[] names = sr.ReadToEnd().Split(new char[] { ' ', ',', '\t','\n','\r' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            sr.Close();
            Array.Sort(names);
            string[] result = new string[names.Length];
            StreamWriter sw = new StreamWriter("outputt.txt");
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = names[i];
                sw.Write("{0}", result[i].ToString());
                sw.Write("\r\n");
                
            }
            sw.Close();

        }
    }
}
