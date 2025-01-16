// Author: AJ Allred
// Date: 1/15/2025
// Description: Class for rolling dice. Contains methods that return a random number between 1 and 6, store the results in a dictionary,
// then displays the results.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Dice
{
    internal class RollDice
    {
        // Create a Random object to generate random numbers
        private Random random = new Random();

        // Roll dice numRolls amount and stores the totals in an array
        public int[] RollDiceMultipleTimes(int numRolls)
        {
            int[] rolls = new int[numRolls];

            for (int i = 0; i < numRolls; i++)
            {
                // Generate a random number between 1 and 6 and store both rolls
                int roll1 = random.Next(1, 7);
                int roll2 = random.Next(1, 7);
                rolls[i] = roll1 + roll2;
            }

            return rolls;
        }

        // Calculates the frequency of each possible total (2-12)
        public int[] CalculateFrequencies(int[] rolls)
        {
            int[] frequencies = new int[11]; // Array to store counts for totals 2-12

            foreach (int roll in rolls)
            {
                frequencies[roll - 2]++; // Map roll (2-12) to position of (0-10)
            }

            return frequencies;
        }

        // Prints the results with percentages and asterisks
        public void PrintResults(int[] rolls, int numRolls)
        {
            int[] frequencies = CalculateFrequencies(rolls);

            for (int i = 0; i < frequencies.Length; i++)
            {
                int total = i + 2; // Map index back to total (2-12)
                // numRolls is cast to a double to perform floating-point division then converted back to an integer so there are no decimals
                int percentage = (int)((frequencies[i] / (double)numRolls) * 100);
                string asterisks = new string('*', percentage);

                Console.WriteLine($"{total}: {asterisks}");
            }
        }
    }


        // Method to simulate multiple dice rolls and store results in a dictionary
        // Used a dictionary to store it in an easy way to display number rolled and calculate percentage
        //public Dictionary<int, int> RollDiceMultipleTimes(int numRolls)
        //{
        //    // Initialize dictionary to store the count of each dice face (2-12)
        //    Dictionary<int, int> rollResults = new Dictionary<int, int>();

        //    // Initialize the dictionary all set to 0
        //    for (int i = 2; i <= 12; i++)
        //    {
        //        rollResults[i] = 0; 
        //    }

        //    // Roll the dice numRolls amount
        //    for (int i = 0; i < numRolls; i++)
        //    {
        //        // Generate a random number between 1 and 6 and store both rolls
        //        int roll1 = random.Next(1, 7); 
        //        int roll2 = random.Next(1, 7);
        //        int rollTotal = roll1 + roll2; // Calculate the total roll
        //        rollResults[rollTotal]++; // Increment the count of the rolled number
        //    }

        //    return rollResults; // Return the dictionary containing the roll results
        //}

        //// Method to Display roll results while using asterisks to represent 1%
        //public void PrintResults(Dictionary<int, int> dictionary, int numRolls)
        //{
        //    foreach (var kvp in dictionary)
        //    {
        //        // numRolls is cast to a double to perform floating-point division then converted back to an integer so there are no decimals
        //        int percentage = (int)((kvp.Value / (double)numRolls) * 100); // Calculate percentage
        //        string asterisks = new string('*', percentage); // Create a string of asterisks
        //        // Write results with the key paired with its number of asterisks 
        //        Console.WriteLine($"{kvp.Key}: {asterisks}");

        //        // To test and see correct percentages
        //        //Console.WriteLine($"{kvp.Key}: {asterisks} ({percentage}%)");
        //    }
        //}
    //}
}
