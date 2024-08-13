using System;
using System.ComponentModel;

/***************************************************************************************************
 * Example use of the Random object
 *
 * To generate a (psuedo) Random number we use a Random object
 *
 * 1. Define a Random object
 * 2. Use the .Next() method on the Random object to get a random value
 *
 * You may specify the range in which you want the Random number generated:
 *
 *   .Next(value) - generate a random int number between 0 and the value-1
 *
 *   .Next(start, end) - generate a random int number between start and the end-1
 *
 *   .NextDoubel() - generate a random doublenumber between 0.o and the 1.0
 *
 **************************************************************************************************/
namespace Unit_2_Day_4_Random_Number_Example
{
    internal class Program
    {
    static void Main(string[] args)
    {
        // Create a random number generator object
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("\n-------- Interation #" + (i+1) + "--------");

            // Generate a random integer between 0 and 99
            int randomNumber = random.Next(100);

            Console.WriteLine("Random number: " + randomNumber);

            // Generate a random number between 1 and 2 (simulating a coin toss)
            int coinToss = random.Next(1, 3);

            // Use the conditional operator (ternary operator) to decide is number is heads or tails
            //
            // 1 == "Heads"
            // 2 == "Tails"
            //
            // Conditional operator provided a conditional value
            //
            //      (condition) ? value-if-true : value-if-false
            //
            // Replacement for and if else statement
            Console.WriteLine("coinToss is: " + coinToss);
            Console.WriteLine("Coin toss: " + ((coinToss == 1) ? "Heads" : "Tails"));
          
            /*******************************************************************************
             * if done with an if-else

                if(coinToss ==1) 
                  {
                    Console.WriteLine("Coin toss: Heads" 
                  }
                  else 
                  {
                    Console.WriteLine("Coin toss: Tails"
                  }

             *********************************************************************************/

            // Generate a random double between 0.0 and 1.0
            double randomDouble = random.NextDouble();
            Console.WriteLine("Random double:           " + randomDouble);

            // the .ToString(#.###) - can format a double value with decimal places
            //                              for display only
            //                              the value in the variable does not change

            Console.WriteLine("Random double (rounded): " + randomDouble.ToString("0.00000"));
            Console.WriteLine("Random double:           " + randomDouble);
            }

        Console.WriteLine("\nPress enter to end program...");
        Console.Read();

        }
    }
}


