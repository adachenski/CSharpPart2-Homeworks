using System;
using System.Linq;
//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the 
//method Array.BinSearch() finds the largest number in the array which is ≤ K.
namespace _04.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            Console.Write("Enter the lenght of the arrey: ");
            int n = int.Parse(Console.ReadLine());

            int[] arrey = new int[n];
            for (int i = 0; i < arrey.Length; i++)
            {
                Console.Write("Elemenr {0} of {1}= ",i,n);
                arrey[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Now enter element K \nthat you trying to find = ");
            int k = int.Parse(Console.ReadLine());
            Array.Sort(arrey);
            int max = arrey.Max();
            int result = Array.BinarySearch(arrey, max);
            int result2 = Array.BinarySearch(arrey, k);
            Console.WriteLine("The biggest element is at position : "+result);
            if (result2>0 )
            {
                Console.WriteLine("your number is at position {0}",result2);
            }
            else
            {
                Console.WriteLine("The number {0} is not on the list.",k);
            }
        }
    }
}
