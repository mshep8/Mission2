namespace Mission2;

public class Simulation
{
    public int[] RunSimulation(int rolls)
    {
        int[] results = new int[13];
        Random random = new Random();

        for (int count = 0; count < rolls; count++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);

            int sum = die1 + die2;
            results[sum]++;
        }
        return results;
    }
}