using System;
using System.Collections.Generic;
using System.Linq;
//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
namespace Homework_Methods
{
    class SayHello
    {
        static void Main()
        {           
            askName();                    
        }
        static void askName()
        {
            Console.WriteLine("What is your name ?");
            string name = Console.ReadLine();
            printName(name);
        }
        static void printName(string name)
        {
            bool isCorect = name.All(char.IsLetter);
            if (isCorect)
            {
                Console.WriteLine("Hello {0} !!!", name);
            }
            else
            {
                Console.WriteLine("Incorect Format");
            }
           
        }
        
    }
}
