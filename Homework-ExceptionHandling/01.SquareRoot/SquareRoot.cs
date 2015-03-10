using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads an integer number and 
//calculates and prints its square root.
//If the number is invalid or negative, print 
//Invalid number. In all cases finally print Good bye.
//Use try-catch-finally block.
namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {


            try
            {
                Console.WriteLine("Enter a number : ");
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    throw new DivideByZeroException();
                }
                float result = FindSquareRoot(n);
                Console.WriteLine(result);

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Not a valid Number!!!");

            }

            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Not a valid Number!!!");

            }
            finally
            {
                Console.WriteLine("Good Bye!!!");
            }
        }
        public static float FindSquareRoot(int number)
        {
            float precision = 0.0001f;
            float min = 0;
            float max = number;
            float result = 0;
            while (max - min > precision)
            {
                result = (min + max) / 2;
                if ((result * result) >= number)
                {
                    max = result;
                }
                else
                {
                    min = result;
                }
            }
            return result;
        }
    }
}
