using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first 
//letter of the string with the first of the key, the second – with the second, etc. When 
//the last key character is reached, the next is the first.
namespace _07.EncodeDecode
{
    class EncodeDecode
    {
        static void Main()
        {
            Console.Write("Enter some Text : ");
            string text = Console.ReadLine();
            char[] arrayText = text.ToCharArray();
            Console.Write("Enter Text that will be the KEY for encoding:  ");
            string key = Console.ReadLine();
            char[] arrayKey = key.ToCharArray();
            List<char> resultEncoding = new List<char>();
            List<char> resultDecoding = new List<char>();
            int count = 0;
            string temp2="";
            for (int i = 0; i < text.Length; i++)
            {
                if (count == arrayKey.Length)
                {
                    count = 0;
                }   
                int temp = arrayText[i] ^ arrayKey[count];
                   temp2 += @"\u00";
                   temp2 +=String.Format("{0:x2}", Convert.ToUInt32(temp.ToString()));
                

                resultEncoding.Add((char)temp);
                ++count;
            }
            Console.WriteLine("Encoding to Hex :");
            Console.WriteLine(temp2);
            count = 0;
            for (int j = 0; j < resultEncoding.Count; j++)
            {
                if (count == arrayKey.Length)
                {
                    count = 0;
                }
                int temp = resultEncoding[j] ^ arrayKey[count];
                resultDecoding.Add((char)temp);
                ++count;
            }
            Console.WriteLine();
            Console.WriteLine("Encoding to char : ");
            Console.WriteLine();
            Console.WriteLine(string.Join("", resultEncoding));
            Console.WriteLine();
            Console.WriteLine("After Decoding: ");
            Console.WriteLine();
            Console.WriteLine(string.Join("", resultDecoding));
        } 
    }
}
