using System;

namespace Day_5__Method_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to my app!");       // Verify the app started

            // Set up a loop to get 5 numbers, one at a time
            for (int i = 0; i < 5; i++)
            {
                // Call the method to get a numeric value
                double aValue = getANumber();

                // Display the value we got from the method
                Console.WriteLine("Number entered was: " + aValue);
            }
            Console.WriteLine("\nThanks for using my app!"); // Verify the app ended

            Console.WriteLine("\nPress enter to end program...");
            Console.ReadLine();
        } // End of Main()
    /****************************************************************
     * Helper methods used by Main()
     ******************************************************************/
    // method starts with a method signature:  return-type name(parameters)

    // This method will get a numeric value from the user
    // It must be static because it will be used by the static method Main() (more later)
    // this method receives no parameters and returns a double (a double can also hold an int value)
        static double getANumber()
        {
            // define a variable for the return value
            double theValue = 0;

            // Ask the user for a numeric value and have them keep trying until we get one

            bool isValidNumber = false;  // Determine is user entered a valid value

            // Loop until we get a valid numeric value

            do  // do loop is used so we ask the user for a number at least once
            {
                // Prompt the user to enter a numeric value
                Console.WriteLine("Please enter a number");

                // Get the input from the user
                string userInput = Console.ReadLine();

                try // We want to handle an Exception that might occur in this block of code
                {
                    // Convert the user input to a double
                    theValue = double.Parse(userInput); // Could cause an Exception
                    isValidNumber = true;  // if .Parse() worked we have a valid number
                }
             // catch (Exception exceptionBlock) will handle every Exception that can occur
                catch (FormatException exceptionBlock) // Handle a FormatException in previous try block
                {
                    Console.WriteLine("\n----- Uh-oh Uh-oh Uh-oh ------");
                    Console.WriteLine("There is problem with " + userInput);
                    Console.WriteLine(exceptionBlock.Message); // Display the system message for the error
                    Console.WriteLine("------ Uh-oh Uh-oh Uh-oh ------\n");
                }
            } while (!isValidNumber); // Loop while we don't have a valid number

            // return the double value from the user input
        return theValue;
        }


    } // End of class Program
} // End of namespace
