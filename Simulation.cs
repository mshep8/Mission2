namespace Mission2;

// This class simulates the rolling of two six-sided dice. It performs the number of rolls
// requested by the user, calculates the sum of each roll, and stores how many times each
// sum occurs in an array. The array is then returned so the results can be displayed in
// a histogram by the main program.

public class Simulation
{
    // This method runs the dice simulation for the number of rolls the user requests
    public int[] RunSimulation(int rolls)
    {
        // Creates an array to store how many times each sum occurs
        int[] results = new int[13];
        
        // Creates a Random object to generate dice values
        Random random = new Random();

        // Loops once for each dice roll
        for (int count = 0; count < rolls; count++)
        {
            // Generates a random number between 1 and 6 for each die
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);

            // Adds the two dice together
            int sum = die1 + die2;
            
            // Increases the count for that sum in the results array
            results[sum]++;
        }
        
        // Returns the array back to the Program class
        return results;
    }
}