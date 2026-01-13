// See https://aka.ms/new-console-template for more information

namespace Mission2;

using static System.Console;

internal class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate? ");
        int rolls = int.Parse(Console.ReadLine());

        Simulation sim = new Simulation();
        int[] results = sim.RunSimulation(rolls);
        
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {rolls}.\n");

        for (int sum = 2; sum <= 12; sum++)
        {
            int percent = results[sum] * 100 / rolls;
            Console.Write($"{sum}: ");

            for (int count = 0; count < percent; count++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}