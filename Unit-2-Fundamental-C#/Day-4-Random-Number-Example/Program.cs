using System;

/***************************************************************************************************
 * Example use of the Random object
 **************************************************************************************************/
namespace Unit_2_Day_4_Random_Number_Example
{
    internal class Program
    {
    static void Main(string[] args)
    {
        // Create a random number generator
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("\n-------- Interation #" + (i+1) + "--------");

            // Generate a random integer between 0 and 99
            int randomNumber = random.Next(100);

            Console.WriteLine("Random number: " + randomNumber);

            // Generate a random number between 1 and 2 (simulating a coin toss)
            int coinToss = random.Next(1, 3);
            Console.WriteLine("Coin toss: " + ((coinToss == 1) ? "Heads" : "Tails"));

            // Generate a random double between 0.0 and 1.0
            double randomDouble = random.NextDouble();
            Console.WriteLine("Random double:           " + randomDouble);
            Console.WriteLine("Random double (rounded): " + randomDouble.ToString("0.000"));
        }

        Console.WriteLine("\nPress enter to end program...");
        Console.Read();

        }
    }
}


