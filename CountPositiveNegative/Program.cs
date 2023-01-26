/*
 * Count Positive Negative
 * 1/26/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and observe the output. How does the
 * program count the number of positive numbers? Why
 * does the count start at 0?
 * Modify the program so that it also counts the number
 * of negative numbers in the array.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            int positiveCount = 0;
            int[] numbers = { 8, 3, 4, 5, -3, 2, -6, -7, -8, 2 };
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    positiveCount++;
                }
            }

            Console.WriteLine("There are " + positiveCount + " positive numbers.");
        }
    }
}
