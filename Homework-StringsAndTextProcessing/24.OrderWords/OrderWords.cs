using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a list of words, separated by 
//spaces and prints the list in an alphabetical order.
namespace _24.OrderWords
{
    class OrderWords
    {
        static void Main()
        {
              
            Console.WriteLine(" Enter list of lords : ");
            string input = Console.ReadLine();
            char[] separators = new char[] { ' ', ',', '.' };
            string[] towns = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string temp = String.Empty;
            int currentIndex = 0;
            for (int i = 0; i < towns.Length; i++)
            {
                string cuttentTown = towns[i];
                for (int j = i; j < towns.Length; j++)
                {
                    if (String.Compare(cuttentTown,towns[j])>0||
                        String.Compare(cuttentTown, towns[j]) == 0)
                    {
                        cuttentTown = towns[j];
                        currentIndex = j;
                    }
                }
                temp = towns[i];
                towns[i] = cuttentTown;
                towns[currentIndex] = temp;
                Console.WriteLine(cuttentTown);
                //Console.WriteLine(currentIndex);
            }
            Console.WriteLine();
        }
    }
}
