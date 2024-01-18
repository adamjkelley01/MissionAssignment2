using System;

namespace MissionAssignment2
{
    // Class representing a dice simulator
    class DiceSimulator
    {
        // Random number generator for simulating dice rolls
        private readonly Random random = new Random();

        // Method to simulate a specified number of dice rolls
        public int[] SimulateRolls(int numberOfRolls)
        {
            // Array to store the count of each possible sum of two dice
            int[] results = new int[13];

            // Loop through the specified number of rolls
            for (int i = 0; i < numberOfRolls; i++)
            {
                // Generate random values for two six-sided dice
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                // Calculate the sum of the two dice
                int sum = dice1 + dice2;

                // Increment the count for the corresponding sum in the results array
                results[sum]++;
            }

            // Return the array containing the count of each possible sum
            return results;
        }
    }
}
