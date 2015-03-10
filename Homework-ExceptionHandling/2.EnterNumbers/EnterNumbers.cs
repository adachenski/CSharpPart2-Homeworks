using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            try
            {
            Console.WriteLine("Enter a start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a end number: ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 10 numbers between {0} and {1}", start, end);
            Console.WriteLine("in increasing order ");

            ReadNumbers(start, end);
          
            }
            catch (System.FormatException ioe)
            {
                Console.WriteLine("Invalid number!! {0}", ioe.Message);
            }
        }

        private static void ReadNumbers(int start, int end)
        {
            int temp = int.MinValue;
            for (int i = 0; i < 10; i++)
            {

                int current = int.Parse(Console.ReadLine());
                ReadFile(temp, current, start, end);
                temp = current;
            }
        }
        static void ReadFile(int temp, int current,int start, int end)
        {
            try
            {
                if (current < temp || current<start||current>end)
                {
                    throw new FileNotFoundException();
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Invalid number! {0}", ex.Message);
            }          
        }
    }
}
