/*
 * Sort Scores
 * 1/26/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and observe the output. In your own
 * words, describe how the Sort() method sorts arrays
 * of numbers.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountScores;
            double[] scores;
            Console.Write("How many scores do you need to enter? >> ");
            amountScores = Convert.ToInt32(Console.ReadLine());
            scores = new double[amountScores];

            for(int i = 0; i < scores.Length; i++)
            {
                Console.Write("Enter a score >> ");
                scores[i] = Convert.ToDouble(Console.ReadLine());
            }

            Array.Sort(scores);
            foreach(double score in scores)
            {
                Console.Write("{0, -6}", score);
            }
            Console.WriteLine();
        }
    }
}
