using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that generates and prints to the 
//console 10 random values in the range [100, 200].
namespace _2.RandomNumbers
{
    class RandomNum
    {
        static void Main()
        {
            Random  tenRandomValues = new Random();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(tenRandomValues.Next(100, 201));
            }
           
        }
    }
}
