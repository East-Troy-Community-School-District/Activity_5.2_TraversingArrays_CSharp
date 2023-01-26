/*
 * Print wtih Foreach
 * 1/26/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and observe the output. Then
 * modify the program by adding "scissors" to the
 * array. Run the program again. Does it display the
 * item you just added? Finally, in your own words,
 * describe how a foreach loop works.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintWithForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stuff = {"paper clips", "pens", "pencils",
                "erasers", "sticky notes", "highlighters"};
            foreach(string item in stuff)
            {
                Console.WriteLine(item);
            }
        }
    }
}
