namespace MissionAssignment2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Display welcome message
            System.Console.WriteLine("Welcome to the dice throwing simulator!");
            System.Console.WriteLine("How many dice would you like to simulate?");

            // Get user input for the number of dice rolls
            int numberOfRolls = int.Parse(Console.ReadLine());

            // Display simulation results header
            System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            System.Console.WriteLine("Each '*' represents 1% of the total number of rolls");
            System.Console.WriteLine($"Total number of rolls = {numberOfRolls}");

            // Create an instance of the DiceSimulator class
            DiceSimulator simulator = new DiceSimulator();

            // Perform dice rolls simulation
            int[] finalresults = simulator.SimulateRolls(numberOfRolls);

            // Print the histogram of simulation results
            PrintHistogram(finalresults, numberOfRolls);

            // Display goodbye message
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }

        // Method to print the histogram of simulation results
        private static void PrintHistogram(int[] results, int totalRolls)
        {
            // Iterate through possible dice values (2 to 12)
            for (int i = 2; i <= 12; i++)
            {
                // Calculate the percentage for the current dice value
                int percentage = results[i] * 100 / totalRolls;

                // Create a string of asterisks representing the percentage
                string asterisks = new string('*', percentage);

                // Display the result and corresponding asterisks
                Console.WriteLine($"{i}:{asterisks}");
            }
        }
    }
}
