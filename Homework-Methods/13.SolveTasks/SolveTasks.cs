using System;
using System.Linq;
using System.Threading;
//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0
namespace _13.SolveTasks
{
    class SolveTasks
    {
        static void Main()
        {
            Welcome();
            Loading();
            Menue();
        }
        static void Menue()
        {
            Console.WriteLine("Choose operation to perform, than press Enter !!! \n"
                + "\nPress \"1\" to Reverse the Digit Of a Numben "
                + "\nPress \"2\" to Calculate the average of a sequence of integers"
                 + "\nPress \"3\" to solve linear equation"
                + "\nOr Press \"Any Key\" to Exit !!!");
            string n = Console.ReadLine();
            if (n == "1")
            {
                Loading();
                Console.Clear();
                Console.Write("Enter your number : ");
                string strNumber = Console.ReadLine();
                string reversedNumber = ReverseTheDigitOfANumben(strNumber);
                Loading();
                Console.WriteLine("number = {0}",strNumber);
                Console.WriteLine("Reversed : {0}", reversedNumber);
                Console.WriteLine();
                Menue();
            }
            if (n == "2")
            {
                Loading();
                Console.Clear();
                Console.Write("Enter your numbers on One line"
                    + "\nSeparated by comma :");
                int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
                double numbersAverage = CalculateTheAverage(numbers);
                Loading();
                Console.WriteLine("The average of your numbers is: " + numbersAverage);
                Console.WriteLine();
                Menue();
            }
            if (n=="3")
            {
                Console.Clear();
                Console.WriteLine("Please enter A, B and C \n"
                + "for solving \"a*X+b=c\"");
                Console.Write("A = ");
                int a = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("{0}*X+b=c",a);
                Console.Write("B = ");
                int b = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("{0}*X+{1}=c", a,b);
                Console.Write("C = ");
                int c = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.Write("{0}*X+{1}={2}", a, b,c);
                Thread.Sleep(1000);
                double x = linearEqasionSolver(a, b, c);
                Console.WriteLine("X = {0}",x );
                Menue();
            }
        }
        static double CalculateTheAverage(int[] numbers)
        {
            double averege = 0;
            int sum = 0;
            int i = 0;
            for (; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            averege = sum / i;
            return averege;
        }
        static string ReverseTheDigitOfANumben(string n)
        {
            char[] array = n.ToCharArray();
            Array.Reverse(array);
            n = "";
            for (int i = 0; i < array.Length; i++)
            {
                n += array[i];
            }
            return n;
        }
        static void Loading()
        {
            int i = 0;
            while (i != 8)
            {
                Console.WriteLine("Loading : (|)");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("Loading : (/)");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("Loading : (~)");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("Loading : (\\)");
                Thread.Sleep(100);
                Console.Clear();
                i++;

            }

        }
        static void Welcome()
        {
            string greatings = "WELCOME BACK DEAR USER !!!";
            int y = Console.WindowHeight / 2;
            int x = (Console.WindowWidth / 2) - greatings.Length;          
            Console.SetCursorPosition(x, y);                               
                                                                            
            for (int i = 0; i < greatings.Length; i++)                       
            {                                                                
                Console.Write(greatings[i]);                                 
                Thread.Sleep(100);                                           
            }                                                                
            Thread.Sleep(1500);                                              
        }
        static double linearEqasionSolver(int a, int b, int c)
        {
            Loading();
            double leftSide = c-b;
            double x = leftSide / a;           
            return x;
        }
    }                                                                          
}
