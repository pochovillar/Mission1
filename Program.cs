using System;
using Mission1;

class DiceSimulator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        DiceRoller diceRoller = new DiceRoller();
        int[] results = diceRoller.SimulateDiceRolls(numberOfRolls);

        // Use DiceSimulator class to access PrintHistogram method
        Mission1.DiceSimulator.PrintHistogram(results, numberOfRolls);
        // comment to test pushing
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}