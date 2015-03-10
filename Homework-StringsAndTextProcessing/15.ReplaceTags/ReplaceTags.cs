using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

//Write a program that replaces in a HTML document given as string all the 
//tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
namespace _15.ReplaceTags
{
    class ReplaceTags
    {
        static void Main()
        {
           // Stopwatch sp = new Stopwatch();
           // sp.Start();
            StreamReader streamReader = new StreamReader(@"..\..\WebAddress.txt");
            string text = streamReader.ReadToEnd().ToString();
            StringBuilder newTextBuilder = new StringBuilder();
            Console.WriteLine("Before conversion");
            Console.WriteLine(text);
            string firstToLook = "<a href=";
            string firstToReplace = "[URL=";

            int start=0, end = 0; ;

            string thirdToLook = "</a>";
            string thirdToReplace = "[/URL]";

            for (int i = 0; i < text.Length; i++)
            {
                int count = 0;
                if (text[i] == firstToLook[count])
                {
                    ReplacePartOfURLWithOther(text, firstToLook, 
                        firstToReplace, ref end, ref i, ref count,
                        ref start,ref newTextBuilder);
                    count = 0;
                }
                if (text[i]==thirdToLook[count])
                {
                    ReplacePartOfURLWithOther(text, thirdToLook, thirdToReplace,
                        ref end, ref i, ref count,ref start, ref newTextBuilder);
                    count = 0;
                }
                if (text[i]=='"')
                {
                    if (text[i+1]=='>')
                    {
                        newTextBuilder.Append(']');
                        continue;
                    }
                }
                newTextBuilder.Append(text[i]);
            }
            Console.WriteLine("After conversion");
            Console.WriteLine(newTextBuilder);
           // sp.Stop();
           // Console.WriteLine(sp.Elapsed);
        }      
        private static void ReplacePartOfURLWithOther(string text,string firstToLook,
            string firstToReplace, ref int end, ref int i, ref int count ,
            ref int start,ref StringBuilder newTextBulder)
        {
            for (int j = i; j < j + firstToLook.Length; j++)
            {
                if (text[j] == firstToLook[count])
                {
                    ++count;
                    if (count == firstToLook.Length)
                    {
                        newTextBulder.Append(firstToReplace);
                        end = j;
                        start = j;
                        count = 0;
                        i = j;
                        break;
                    }
                }
                else
                {
                    count = 0;
                    break;
                }
            }
        }
    }
}
