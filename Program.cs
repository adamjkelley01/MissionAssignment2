namespace MissionAssignment2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the dice throwing simulator!");
            System.Console.WriteLine("How many dice would you like to simulate?");

            int numberOfRolls = int.Parse(Console.ReadLine());

            System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            System.Console.WriteLine("Each '*' represents 1% of the total number of rolls");
            System.Console.WriteLine($"Total number of rolls = {numberOfRolls}");

            DiceSimulator simulator = new DiceSimulator();
            int[] finalresults = simulator.SimulateRolls(numberOfRolls);

            PrintHistogram(finalresults, numberOfRolls);

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }

        private static void PrintHistogram(int[] results, int totalRolls)
        {
            for (int i = 2; i <= 12; i++)
            {
                int percentage = results[i] * 100 / totalRolls;
                string asterisks = new string('*', percentage);
                Console.WriteLine($"{i}:{asterisks}");

            }

        }
    }
}


