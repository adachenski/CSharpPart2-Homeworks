using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that enters file name along with its full file path 
//(e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.
namespace _03.ReadFileContents
{
    class FileContents
    {
        static void Main()
        {           
            try
            {
                //StreamReader readFile = new StreamReader(@"..\..\file.txt");
                StreamReader readFile = new StreamReader(@"C:\Users\USER\Documents\Visual Studio 2013\Projects\Homework-ExceptionHandling\03.ReadFileContents\file.txt");
                string text = readFile.ReadToEnd().ToString();
                Console.WriteLine(text);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("{0} \nTo see the file content "
                    +"you can uncoment the relative Path above!!!",ex.Message);
            }
            catch (System.ArgumentException ex)
            {
                Console.WriteLine("{0} \nTo see the file content "
                    + "you can uncoment the relative Path above!!!", ex.Message);
            }
        }
    }
}
