using System;
using System.Collections.Generic;
using System.Linq;
//Write a program that finds all prime numbers in the range 
//[1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
namespace _15.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            bool[] arrey = new bool[100000000];
            
            int []arreyOfPrimes= {2,3,5,7};
            int count =0;

            while (count!=arreyOfPrimes.Length)
            {
                for (int i = 0; i < arrey.Length; i+=arreyOfPrimes[count])
                {
                    arrey[i] = true;

                }
                ++count;
            }
            arrey[1] = true;
            arrey[2] = false;
            arrey[3] = false;
            arrey[5] = false;
            arrey[7] = false;
         
            for (int i = 0; i < arrey.Length; i++)
            {
                if (arrey[i]==false)
                {
                    Console.Write(i+",");
                }
            }         
        }
    }
}
