using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Modify the solution of the previous problem to replace only whole words (not strings).
namespace _07.ReplaceSub_string
{
    class SubStringReplace
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"..\..\LoremIpsum.txt");
            string read = sr.ReadLine();
            string readToString = read.ToString();
            string replace = readToString.Replace(" start ", " finish ");
           // Console.WriteLine(replace);
            StreamWriter sw = new StreamWriter("result.txt");
            sw.Write(replace);
            while (read!=null)
            {
                read = sr.ReadLine();
                if (read!=null)
                {
                    readToString = read.ToString();
                    replace = readToString.Replace(" start ", " finish ");
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
