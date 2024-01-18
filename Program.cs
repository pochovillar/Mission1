// See https://aka.ms/new-console-template for more information
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

        PrintHistogram(results, numberOfRolls);

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

}
