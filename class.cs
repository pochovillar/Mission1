using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission1
{
    internal class @class
    {
        class DiceRoller
        {
            private Random random;

            public DiceRoller()
            {
                random = new Random();
            }

            public int[] SimulateDiceRolls(int numberOfRolls)
            {
                int[] results = new int[13];

                for (int i = 0; i < numberOfRolls; i++)
                {
                    int dice1 = random.Next(1, 7);
                    int dice2 = random.Next(1, 7);
                    int sum = dice1 + dice2;

                    results[sum]++;
                }

                return results;
            }

            static void PrintHistogram(int[] results, int totalRolls)
            {
                Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
                Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
                Console.WriteLine($"Total number of rolls = {totalRolls}.");

                for (int i = 2; i <= 12; i++)
                {
                    int percentage = results[i] * 100 / totalRolls;
                    Console.WriteLine($"{i}: {new string('*', percentage)}");
                }
            }
        }
    }
}
