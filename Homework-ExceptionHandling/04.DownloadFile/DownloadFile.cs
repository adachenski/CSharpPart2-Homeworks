using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
//Write a program that downloads a file from Internet 
//(e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free
//any used resources in the finally block.
namespace _04.DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            using (WebClient Client = new WebClient())
            {
             
                try
                {
                    string remoteUri = "http://www.rantsports.com/clubhouse/files/2013/12/";

                    string fileName = "opener-@athletic_babes3.jpg", myStringWebResource = null;

                    myStringWebResource = remoteUri + fileName;
                    // Download the Web resource and save it into the current filesystem folder.
                    Client.DownloadFile(myStringWebResource, fileName);
                }
                catch (System.Net.WebException ex)
                {
                    Console.WriteLine("The file is no longer aveilable \n{0}",ex.Message);
                }
            }
            Process.Start(@"..\..\bin\Debug\opener-@athletic_babes3.jpg");
        }
    }
}
