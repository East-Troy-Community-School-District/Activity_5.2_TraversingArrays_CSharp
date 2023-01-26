/*
 * Populate Array
 * 1/26/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and see what it does. How does the
 * program adjust the array to accomodate the different
 * amount of names the user wishes to enter?
 * Currently, the program uses a while loop to add the
 * names to the array. Modify the program so that it
 * uses a for loop instead. Which version do you prefer?
 * How does the program print all the elements within the
 * array on a single line? Why must the loop that prints
 * the elements stop short by one element?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfNames;
            string[] names;

            Console.Write("Enter the amount of names you need to enter >> ");
            amountOfNames = Convert.ToInt32(Console.ReadLine());
            names = new string[amountOfNames];

            int i = 0;
            while(i < names.Length)
            {
                Console.Write("Enter a name >> ");
                names[i] = Console.ReadLine();
                i++;
            }

            for(int j = 0; j < names.Length - 1; j++)
            {
                Console.Write(names[j] + ", ");
            }
            Console.WriteLine(names[names.Length - 1]);
        }
    }
}
