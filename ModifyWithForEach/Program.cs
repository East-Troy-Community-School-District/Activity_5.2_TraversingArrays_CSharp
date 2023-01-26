/*
 * Modify with Foreach
 * 1/26/2023
 * C#.NET I
 * 
 * Instructions:
 * Try running the program. You should notice that
 * it does not work! Why? Fix the program so that
 * it sets each element in the array to a random
 * number between 0 and 10, exclusive.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyWithForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = new int[100];
            Random generator = new Random();

            foreach(int number in randomNumbers)
            {
                number = generator.Next(0, 10);
            }

            foreach(int number in randomNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
