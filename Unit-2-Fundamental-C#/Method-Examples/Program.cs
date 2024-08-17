using System;

namespace Method_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the app!");

            // Set up a loop to get 5 numbers, one at a time
            for (int i = 0; i < 5; i++)
            {
                // Call the method to get a numeric value
                double userValue = GetANumber();

                // display the value we got from the method
                Console.WriteLine("The number eneterd was: " + userValue);
            }
            // Call a method to return a number and a string
            // A method can only return ONE value
            // If you need a method to return more than one value we use out parameters
            //
            // The out parameter allows you to pass a variable to a method that is set by the method

            Console.WriteLine("\n-------------");

            double someValue = 0;
            string someString = " ";

            GetANumAndAString(out someValue, out someString);

            Console.WriteLine("Hey " + someString + " you enetered " + someValue);


            Console.WriteLine("\nThanks for using the app!");
        } //end of main
        /***********************************************
         * Helper methods used by Main()
         * *********************************************/
        // method starts with a method signature: return-type name(parameters)

        // This method will return a number and string using out parameters
        // It does not use a typical return statement
        //
        // The keyword out says the method will set the value for the calling method

        static void GetANumAndAString(out double aNum, out string aName)
        {
            // set the out paramerto for aNum 
            aNum = GetANumber(); // Using existing method to get a number

            Console.WriteLine("Please enter your name.");
            aName = Console.ReadLine(); // set the out parameter for aName
        }



        // This method will get a numeric value from the user
        // It must be static because it will be used by the static method main
        static double GetANumber() //this method recives no parameters and returns a double
        {
            // define a variable for the return value
            double theValue = 0;

            //Ask the user for a numeric value and have them keep trying until we get one
            bool isValidNumber = false; // determine if the user entered a valid value

            // Loop until we get a valid numeric value

            do // do loop is used so we can ask the user for a number at least once
            {



                // Prompt the user to enter a numeric value
                Console.WriteLine("Please enter a numeric value.");

                // Get the input from the user
                string userInput = Console.ReadLine();

                try //handle an exception that might occur in this block of code
                {
                    // Convert the user input to a double
                    theValue = double.Parse(userInput); //could cause Exception
                    isValidNumber = true; //if .Parse() worked we have a valid number
                }
                //catch (Exception exceptionBlock) will handle every Exception that can occur
                catch (FormatException exceptionBlock) //Handle a FormatException in previous try block
                {
                    Console.WriteLine("\nUh-oh, Uh-oh, Uh-oh");
                    Console.WriteLine("There is a problem with " + userInput);
                    Console.WriteLine(exceptionBlock.Message); // Display the system message for the error
                    Console.WriteLine("Uh-oh, Uh-oh, Uh-oh\n");
                    isValidNumber= false;
                }
            } while (!isValidNumber); // loop while we don't have a valid number   
               
            // Return the double value from the user
                return theValue;
            
        }
    }     //end of class program
}         // end of namespace
