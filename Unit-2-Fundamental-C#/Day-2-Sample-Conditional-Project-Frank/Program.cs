using System;   // Give me access to C# system stuff


namespace Day_2_Sample_Conditional_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for an odd number between 11 and 17
            // Verify they have entered a correct values
            //
            // A number is odd is if it is not evenly divisible by 2
            //   (if we divide it by 2 and the remainder is not 0, it's odd)
            //
            // Luckily C# has the modulus operator (%) which provides the remainder after a divided

            Console.WriteLine("Please enter an odd number between 11 and 17");
            int theNumber = int.Parse(Console.ReadLine()); // Get user input and convert to an int

            // Show the user what we got from them
            Console.WriteLine("You entered: " + theNumber);

            // Verify the number is between 11 and 17
            if (theNumber >= 11 && theNumber <= 17 && theNumber % 2 != 0)
            {
                Console.WriteLine("The value IS odd and between 11 and 17");
            }
            else
            {
                Console.WriteLine("The value IS NOT odd and between 11 and 17");
            }

            // Make Visual Studio keep the console window open until we are done
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
