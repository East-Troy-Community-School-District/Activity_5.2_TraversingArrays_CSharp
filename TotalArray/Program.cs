/*
 * Total Array
 * 1/26/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and observe the output. How does the
 * program total the array? Why does the total start at
 * 0?
 * A common task when working with arrays is to find the
 * sum of the values within the array. It is so common, that
 * we gave a special term for variables like total; we call
 * them accumulators.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0.0;
            double[] measurements = { 4.5, 6.2, 8.8, 9.3, 4.75 };

            for (int i = 0; i < measurements.Length; i++)
            {
                total += measurements[i];
            }

            Console.WriteLine("Total: " + total);
        }
    }
}
