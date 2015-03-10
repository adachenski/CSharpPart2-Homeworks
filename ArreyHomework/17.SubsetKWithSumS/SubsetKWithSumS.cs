using System;
using System.Collections.Generic;
using System.Linq;

namespace _16_SubsetWithSumS
{
    class SubsetWithSumS
    {
        static void Main()
        {
            int[] arrey = { 20, 3, 2, 4, 30,  1, 20, 2 };
            int s = 8;
            int k = 3;

            int tempK = k;
            int temp = s;
            int count = 0;
            int start = 0;

            while (temp!=0)
            {
                temp -= arrey[count];
                --tempK;
                if (temp < 0 || k < 0)
                {
                    temp += arrey[count]; 
                    ++tempK;
                }
                if (temp == 0&& tempK==0)
                {
                    Console.WriteLine("yes");
                    break;
                }
                if (count==arrey.Length-1)
                {
                    ++start;
                    if (start==arrey.Length-3)
                    {
                        Console.WriteLine("SubSet not found!!!");
                        break;
                    }
                    count = start - 1;
                    temp = s;
                    tempK = k;
                }
                ++count;
            }
         
        } 
    }
}
