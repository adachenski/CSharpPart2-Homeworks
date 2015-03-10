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
            Console.Write("Enter path of input: ");
            string inputPath = Console.ReadLine();
            StreamReader sr = new StreamReader(inputPath);
            string read = sr.ReadLine();
            string readToString = read.ToString();
            Console.Write("Choose word that you gonna replace: ");
            string replacingWord = Console.ReadLine();
            Console.Write("Choose word that you want to replace: ");
            string pick = Console.ReadLine();
            string replace = readToString.Replace(replacingWord, pick);
            // Console.WriteLine(replace);
            Console.WriteLine("Enter output path : ");
            string output = Console.ReadLine();

            StreamWriter sw = new StreamWriter(output);
            sw.Write(replace);
            while (read != null)
            {
                read = sr.ReadLine();
                if (read != null)
                {
                    readToString = read.ToString();
                    replace = readToString.Replace(replacingWord, pick);
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
