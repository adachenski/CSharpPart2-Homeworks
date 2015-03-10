using System;
using System.Collections.Generic;
using System.Linq;
//Write a program that compares two char arrays lexicographically (letter by letter).
class Program
{
    static void Main()
    {
        char[] arrey1 ={'h','b','d','c','r','v','g','c','x','a','o','a','s','r','v','x','k','k','a','m',
        'n','y','y','j','i','s','i','x','t','t'};
        char[] arrey2 ={'x','d','t','c','c','j','m','u','e','s','h','v','z','l','d','s','j','f','c','q',
         'n','g','b','c','a','k','k','f','r','v'};


      
         // Random newRand = new Random();
        //for (int i = 0; i < 30; i++)
        //{
        //    int temp = newRand.Next(97, 123);
        //    Console.Write("\'{0}\',",(char)temp);
        //}

        for (int i = 0; i < arrey1.Length; i++)
        {
            if (arrey1[i] > arrey2[i])
            {
                Console.WriteLine(arrey1[i] + ">" + arrey2[i]);
            }
            if (arrey1[i] < arrey2[i])
            {
                Console.WriteLine(arrey1[i] + "<" + arrey2[i]);
            }
            if (arrey1[i] == arrey2[i])
            {
                Console.WriteLine(arrey1[i] + "=" + arrey2[i]);
            }
        }
    }
}

