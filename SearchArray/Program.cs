/*
 * Search Array
 * 1/26/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and see what it does. This program
 * implements a sequential search. In a sequential search,
 * the elements in the array are check in order to see if
 * they match the target (i.e., the item we are searching
 * for). Usually, if the item is found, the program breaks
 * out of the loop. 
 * One more question, what does the if statement on line 44 check?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool foundName = false;
            string name;
            string[] roster = { "Jimbo", "Jen", "Jenny", "Jim" };

            Console.Write("Enter a name to search for >> ");
            name = Console.ReadLine();

            for(int i = 0; i < roster.Length; i++)
            {
                if(roster[i] == name)
                {
                    Console.WriteLine("That person is on the roster!");
                    foundName = true;
                    break;
                }
            }
            if (!foundName)
            {
                Console.WriteLine("That person is not on the roster!");
            }
        }
    }
}
