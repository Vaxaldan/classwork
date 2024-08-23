using System;
using System.Collections;
using System.Collections.Generic;

namespace Day_2_ArrayList_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*******************************************
           *  Generic Collection Object - ArrayList
           *  (any data type can be stored)
           *  ***************************************/
            // Define an ArrayList to hold some numbers
            ArrayList someNumbers = new ArrayList(); // Note: () after ArrayList - they are required

            do
            {
                // Get a number from the user and store it in the ArrayList

                someNumbers.Add(GetANumber()); // Add the number entered by the user to the ArrayList

            } while (moreInput()); // Loop while the users says they have more input

            // Display how many numbers they eneterd and what they were
            Console.WriteLine("You eneterd " + someNumbers.Count + " numbers");

            Console.Write("The numbers you enterd were: ");
            foreach (double aNumber in someNumbers)
            {
                Console.Write(aNumber + " ");
            }
            Console.WriteLine("\n************************************************************************\n");
            /*******************************************
             *  Non-generic Collection Object - List
             *  (Specific datatype must be stored)
             *  ***************************************/
            
            
            // Define an ArrayList to hold some numbers
            // You specify the type of data to be stored inside the diamond brackets <>
            List<double> someNumbersList = new List<double>(); // Note: () after ArrayList - they are required

            do
            {
                // Get a number from the user and store it in the ArrayList

                someNumbersList.Add(GetANumber()); // Add the number entered by the user to the ArrayList

            } while (moreInput()); // Loop while the users says they have more input

            // Display how many numbers they eneterd and what they were
            Console.WriteLine("You eneterd " + someNumbersList.Count + " numbers");

            Console.Write("The numbers you enterd were: ");
            foreach (double aNumber in someNumbersList)
            {
                Console.Write(aNumber + " ");
            }

            
            Console.WriteLine("\nPress enter to end.");
            Console.Read();

        }  // End of Main()

        /****************************************************************************************************
         * This method will get a numeric value from the user
         * It must be static because it will be used by the static method Main() (more later)
         * this method receives no parameters and returns a double (a double can also hold an int value)
        ****************************************************************************************************/
        static double GetANumber()
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
        } // End of getANumber() method

        /************************************************************************************
         * return a boolean value to indicate if the user has more input
         ***********************************************************************************/
        static bool moreInput()
        {
            bool isThereInput = false;  // Hold teh return value 

            string whatUserTyped = "";     // Hold what the user enters

            bool getInput = true;   // Control the user interaction loop

            do
            {
                // Ask the user if they have any numbers to enter (Y/N)
                Console.WriteLine("Do you have any numbers to enter (Y/N)?");
                whatUserTyped = Console.ReadLine();

                whatUserTyped = whatUserTyped.ToUpper();

                string firstChar = whatUserTyped.Substring(0, 1);

                if (firstChar == "Y")
                {
                    getInput = false;
                    isThereInput = true;
                }
                else
                {
                    if (firstChar == "N")
                    {
                        getInput = false;
                        isThereInput = false;
                    }
                }
            } while (getInput); // Loop while we get input

            return isThereInput;
        }

    } // End of class Program
} // End of namespace
