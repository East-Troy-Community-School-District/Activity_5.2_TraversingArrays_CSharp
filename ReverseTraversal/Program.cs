/*
 * Reverse Traversal
 * Pawelski
 * 10/15/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Run the program and observe the output. How does the
 * program traverse the array? Why must the variable i
 * start at order.Length - 1 instead of order.Length 
 * (HINT: Give it a try and see what happens!)?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] order = { "fourth", "third", "second", "first" };

            for (int i = order.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(order[i]);
            }
        }
    }
}
