using System;
using System.Collections.Generic;
//Write a program that finds the most frequent number in an array.
namespace _09.FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
           // int[] arrey = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };//result: 4 (5 times)


            Console.Write("Enter length of the arrey: ");  //
                                                           //
            int length = int.Parse(Console.ReadLine());    //
            int[] arrey = new int[length];                 //to test with the default example above!!!
                                                           //you can comment this part and uncoment the part above
            for (int i = 0; i < length; i++)               //
            {                                              //
                Console.Write("Element {0} = ", i + 1);    //
                arrey[i] = int.Parse(Console.ReadLine());  //
            }                                              //
                                                           //

            int count = 0, totalcoun = 0, currentymbol = 0, startSymbol = 0; ;

            for (int i = 0; i < arrey.Length; i++)
            {
                for (int j = i; j < arrey.Length; j++)
                {
                    if (arrey[j]==arrey[i])
                    {
                        ++count;
                    }
                    if (j==i)
                    {
                        currentymbol = arrey[j];
                    }
                }
                if (count>totalcoun)
                {
                    totalcoun = count;
                    startSymbol = currentymbol;
                }
                count = 0;
            }
            Console.WriteLine("{0} ({1} times)",startSymbol,totalcoun);
            //Console.WriteLine(totalcoun);
        }
    }
}
