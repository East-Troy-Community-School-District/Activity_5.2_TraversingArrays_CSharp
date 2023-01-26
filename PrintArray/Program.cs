/*
 * Print Array
 * 1/26/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and observe the output. In your
 * own words, how does the for loop traverse the
 * array? Next, modify the program by adding "yellow" 
 * to the array. Run the program again. Your item 
 * was not displayed! Why? How could we write the
 * for loop to eliminate this issue?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "green", "blue" };
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(colors[i]);
            }
        }
    }
}
