// Author: AJ Allred
// Date: 1/15/2025
// Description: This is a program that rolls 2 dice x amount of times, which is determined by the user.
// Following the rolls, the results are displayed using astericks. This assignment demonstrates using classes in C#.

using System.Collections.Generic;
using Mission2Dice;

internal class Program
{
    public static void Main(string[] args)
    {
        //Create instances of other classes
        RollDice rd = new RollDice();

        //Creating variables used later
        int numRolls = 0;
        string input = "";
        //Dictionary<int, int> rollResults = new Dictionary<int, int>();

        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        Console.WriteLine("How many dice rolls would you like to simulate?\n");

        //Create loop if user input is not an integer
        while (true)
        {
            input = Console.ReadLine();

            // Try to convert the input to an integer
            if (int.TryParse(input, out numRolls))
            {
                //Console.WriteLine("You entered: " + numRolls);
                break; // Exit the loop when an integer
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        //Roll dice as many times as inputted and store it in a dictionary with its value - referenced in RollDice.cs
        //rollResults = rd.RollDiceMultipleTimes(numRolls);

        //Roll dice as many times as inputted and store it in a dictionary with its value - referenced in RollDice.cs
        int[] rollResults = rd.RollDiceMultipleTimes(numRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls + "\n");

        // Print the results of the number of rolls - referenced in RollDice.cs
        rd.PrintResults(rollResults, numRolls);

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }

}
    