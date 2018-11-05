using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 1, 10 };


            int max = 10;


            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            int[] freq = new int[max + 1];

            for (int i = 0; i < numbers.Length; i++)
            {

                freq[numbers[i]]++;

            }

            for (int i = 0; i < freq.Length; i++)
            {
                Console.WriteLine($"[{i}] occurs {freq[i]} time(s) in the array.");
            }




        }
    }
}

