using System;
using System.Collections.Generic;
using System.Linq;

namespace _16_SubsetWithSumS
{
    class SubsetWithSumS
    {
        static void Main()
        {
            int[] arrey = { 20, 30, 2, 4, 30, 1, 20, 2 };
            //Console.Write("Enter length of the arrey: ");  //
            //                                               //
            //int length = int.Parse(Console.ReadLine());    //
            //int[] arrey = new int[length];                 //to test with the default example above!!!
            //                                               //you can comment this part and uncoment the part above
            //for (int i = 0; i < length; i++)               //
            //{                                              //
            //    Console.Write("Element {0} = ", i + 1);    //
            //    arrey[i] = int.Parse(Console.ReadLine());  //
            //}
            //Console.WriteLine("Enter S = ");
            int s = 8;//int.Parse(Console.ReadLine()); 
            int temp = s;
            int count = 0;
            int start = 0;

            while (temp!=0)
            {
                temp -= arrey[count];
                if (temp<0)
                {
                    temp += arrey[count];
                }
                if (temp == 0)
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
                }
                ++count;
            }
         
        } 
    }
}
