// See https://aka.ms/new-console-template for more information

// Mary Catherine Shepherd
// IS 413
// Mission 2 Assignment
// Program simulates the rolling of two six-sided dice. Keeps track of the number of
// times that each combination is thrown. The user can choose how many times the "dice"
// be thrown. The results of the sum of the throw is stored in an array. That array will
// be printed in a histogram using the * character that shows the total percentage for
// each number that was rolled. Each * will represent 1% of the total rolls.
namespace Mission2;

using static System.Console;

// This is the main Program class where the application starts running
internal class Program
{
    // This is the Main method
    public static void Main(string[] args)
    {
        // Introduces the program
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate? ");
        // Reads the user response
        int rolls = int.Parse(Console.ReadLine());

        // Creates a Simulation object so the dice rolls can run
        Simulation sim = new Simulation();
        
        // Runs the simulation and stores the results in an array
        int[] results = sim.RunSimulation(rolls);
        
        // Prints the header for the histogram
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {rolls}.\n");

        // Loops through all the possible dice sums
        for (int sum = 2; sum <= 12; sum++)
        {
            // Calculates the percent of rolls this sum represents
            int percent = results[sum] * 100 / rolls;
            
            // Prints the dice sum label
            Console.Write($"{sum}: ");
            
            // Prints one * for each percent
            for (int count = 0; count < percent; count++)
            {
                Console.Write("*");
            }
            
            // Moves to the next line for the next sum
            Console.WriteLine();
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}