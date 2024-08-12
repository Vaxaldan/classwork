using System;
using System.Threading; // Give me access to basic C# System code

namespace Day_3_Loop_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for three numbers
            // add the numbers
            // find the average of the numbers
            // display the three numbers, the sum average

            // Define variables reused in the loop
            double numberSum = 0;  // hold the sum of the numbers
            double aNumber   = 0;  // hold a number entered by the user
            int    numNums   = 2;  // The number of numbers we want the user to enter


            /******* Solution Using a for-loop ***********************************************
            // Ask the user how many numbers they have
            Console.WriteLine("How many numbers do you have to enter?");
            numNums = int.Parse(Console.ReadLine());

            // Loop through process - as many times as the user indicates
            //
            //  1. int i will be set to 0 (initialize)
            //  2. Check i < numNums (check condition)
            //     if condition is true - perform the loop process (code between {})
            //     if condition is false - exit the loop
            //  3. Increment the int i (i++)
            //  4. Go back to step 2
            //
            for (int i = 0; i < numNums; i++)  // i will go from 0, 1, 2 inside the loop (3 times)
            {
                // Ask the user for a number
                Console.WriteLine("Please enter number " + (i+1) + " of " + numNums);
                aNumber = double.Parse(Console.ReadLine()); // Get a line from user and convert to int

                // Add the number to the sum
                numberSum = numberSum + aNumber;

            } // End of for loop
            *********** End of for-loop solution ************************************************/

            /********* Solution using a while-loop **********************************************

             // Loop until the user tells us they have no more numbers to enter (type end instead of a number)

             bool shouldLoop = true;  // Control how long we loop
             numNums = 0;             // Keep track of how many numbers user entered

             //while (shouldLoop) // loop while shouldLoop is true
             while(true)  // Typical use if break is used to exit loop
             {
                Console.WriteLine("Enter a number or end to finish");
                string userInput = Console.ReadLine();

                // Did they type "end" - if so exit set to exit loop
                if (userInput == "end")
                {
                    //shouldLoop = false;  // set the loop control variable to end the loop
                    break;   // exit the loop
                }
                // else is unnecessary if using while(true) and break style of looping
                else
                {
                    numNums++;    // Count the fact a number was entered by the user
                    aNumber = double.Parse(userInput); // convert the data from a string to double
                    numberSum += aNumber;              // Add a Number to the sum variable
                }
             }
            *********** End of while-loop solution ************************************************/

            /********* Solution using a do-while loop **********************************************
             *********** End of do-while loop solution *********************************************/

            // Loop until the user tells us they have no more numbers to enter (type end instead of a number)

            // Define userInput outside teh loop so the entire program can see it
            string userInput = "";  // Hold the data entered by the user

            do
            {
                Console.WriteLine("Enter a number or end to finish");
                userInput = Console.ReadLine();

                if (userInput == "end")
                {
                    continue;  // skip to the end of the loop and check the while condition
                }

                // User did not enter end, so we process the data as a number
                numNums++;                           // Count the fact a number was entered by the user
                aNumber   = double.Parse(userInput); // convert the data from a string to double
                numberSum += aNumber;                // Add a Number to the sum variable

            } while (userInput != "end");  // Loop as long as they didn't type end
                                           // exit the loop if they end





            // At this point, we have the numbers summed and numNums contains the number of numbers entered

            // find the average of the numbers - Note use of double so we can have decimal places
            double numberAverage = (double) numberSum / numNums; // numberSum / numNums; // This will produce an int result (no decimal)

// Alternate coding technique
//double numberAverage =  numberSum / 3.0;  // Make the literal a double

// Display the sum average
Console.WriteLine("The sum is: " + numberSum);
Console.WriteLine("The average is: " + numberAverage);

// Make Visual Studio wait to close the console window
Console.WriteLine("Press enter to finish");
Console.ReadLine();

}
}
}
