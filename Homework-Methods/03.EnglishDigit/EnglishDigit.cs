using System;
//Write a method that returns the last digit of given integer as an English word
namespace _03.EnglishDigit
{
    class EnglishDigit
    {
        static void Main()
        {
            LastDigitAsAWord();
        }
        static void LastDigitAsAWord()
        {
            int number = int.Parse(Console.ReadLine());
            int lastDigit = number % 10;
            string[] numberWords = { "zero","one", "two", "three", "four",
                                       "five","six","seven","eight","nine"};
            for (int i = 0; i <= lastDigit; i++)
            {
                if (lastDigit == i)
                {
                    Console.WriteLine(numberWords[i]);
                }

            }
        }
    }
}
