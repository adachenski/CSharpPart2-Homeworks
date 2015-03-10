using System;
using System.Numerics;
//Write a method that adds two positive integer numbers represented as arrays of 
//digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.
namespace _08.NumberAsArray
{
    class NumbersAsArrey
    {
        static void Main()
        {
            Console.Write("Enter your First Number : ");
            string first = Console.ReadLine();
            Console.Write("Enter your Second Number: ");
            string second = Console.ReadLine();
          
            BigInteger[] arrayFirst = new BigInteger[first.Length];
            BigInteger[] arraySecond = new BigInteger[second.Length];
           

            int firstLenght = first.Length-1;
            int secondLenght = second.Length - 1;
            int resultLenght = firstLenght+1>secondLenght+1?firstLenght+1:secondLenght+1;
            BigInteger[] arrayResults = new BigInteger[resultLenght];

            StringToBigInteger(first, arrayFirst, firstLenght);
            StringToBigInteger(second, arraySecond, secondLenght);

            int reminder = 0;
            int nextLine = 0;
            Console.Write("The Result is           : ");
            AddingTwoArrays(arrayFirst, arraySecond,arrayResults,ref reminder,ref nextLine);

            for (int i = arrayResults.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayResults[i]);
            }
        }

        private static int StringToBigInteger(string number, BigInteger[] array, int numberLenght)
        {
            for (int i = 0; i < number.Length; i++)
            {
                array[numberLenght] = number[i] - '0';
                numberLenght--;
            }
            return numberLenght;
        }
        private static void AddingTwoArrays(BigInteger[] arrayOne, BigInteger[] arrayTwo,
            BigInteger[] arreyResult, ref int reminder, ref int nextLine)
        {
            int tempArrOne = 0, tempArrTwo = 0;
            for (int i = 0; i < arreyResult.Length; i++)
            {
                if (i<arrayOne.Length)
                {
                    tempArrOne = (int)arrayOne[i];
                }
                else
                {
                    tempArrOne = 0;
                }
                if (i < arrayTwo.Length)
                {
                    tempArrTwo = (int)arrayTwo[i];
                }
                else
                {
                    tempArrTwo = 0;
                }
               
                BigInteger sum = tempArrOne + tempArrTwo + nextLine;
                if (i == arreyResult.Length - 1)
                {
                    int secondDigit = (int)sum % 10;
                    arreyResult[i] = secondDigit;
                    if (sum/10!=0)
                    {
                        arreyResult[i + 1] = sum / 10;
                    }
                    
                    break;
                }
                if (sum > 9)
                {

                    reminder = (int)sum % 10;
                    nextLine = (int)sum / 10;
                    arreyResult[i] = reminder;
                }
                else
                {
                    arreyResult[i] = sum;
                    reminder = 0;
                    nextLine = 0;
                }
            }
        }
    }
}
