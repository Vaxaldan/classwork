using System;
using System.IO; // gives access to the basic C# system code

namespace Day_3_loop_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ask the user for three number
            // add the numbers 
            // find the average of the numbers
            // display the three numbers, the sum, and the average

            // Define variables reused in the loop
            double numSum = 0; // hold the sum of the numbers
            double aNum = 0;  //  hold the number entered by the user
            int numCycle = 5; // The number of number we want the user to enter


            /********* solution using a for-loop **************************
            // Ask the user how many numbers they have
            Console.WriteLine("How many numbers do you have to enter?");
            numCycle = int.Parse(Console.ReadLine());

            // Loop through process - as many times as the user indicates
            //
            // 1. int i will be set to 0
            // 2. check i < numCycle (check condition)
            //    if condition is true - preform the loop process (code between {})
            //    if condition is false - exit loop
            // 3. Increment the int i (i++)
            // 4. Go back to step 2
            //
            for (int i = 0; i < numCycle; i++) //i will go from 0, 1, 2 inside the loop
            {
                // ask the user for three numbers
                Console.WriteLine("Please enter a number. " + (i+1) + " of " + numCycle);
                aNum = int.Parse(Console.ReadLine()); //Get a line from user and convert to int

                // Add the number to the sum
                numSum = numSum + aNum;

            } // end of for loop

            **********End of for-loop solution ***********************************************/



            /****************** Solution using a while-loop ***********************************
            
            // Loop until the user tells us they have no more numbers to enter (type end to enter)

            bool shouldLoop = true; //Controll how long we loop
            numCycle = 0;           // keeps track of how many numbers user has entered

            while (true) //Typical use if break is used to exit loop
            {
                Console.WriteLine("Enter a number or end to finish.");
                string userInput = Console.ReadLine();

                // Did they type "end" - if so, exit loop
                if (userInput == "end")
                {
                    //shouldLoop = false; //set the loop control variable to end the loop
                    break; //exit the loop
                }
                // else is unnecessary if using the while(true) and break style of looping
                else
                {
                    numCycle++;                     // count that a number was enterd by the user
                    aNum = double.Parse(userInput); // convert user data from a string to a double
                    numSum += aNum;                 // adds a number to the sum variable 
                }
            }
            
            *************End of while-loop solution *************/

            /************Solution using a do-while loop***********/

            // Loop until the user tells us they have no more numbers to enter (type end to enter)
            // Allows the user to have no numbers to enter

            // Defined userInput outside the loop 
            string userInput; // Hold data entered by the user

            do
            {
                Console.WriteLine("Enter a number or end to finish.");
                userInput = Console.ReadLine();

                if (userInput == "end")
                {
                    continue; //skip to the end of the loop and check while condition
                }
 
                numCycle++;                     //Count the fact a number was enterd by the user
                aNum = double.Parse(userInput); // convert the data from a string to a double
                numSum += aNum;                 // 

            } while(userInput != "end"); //loop as long as user didn't type end



            // at this point, we have the numbers summed and numCycle contains the number of numbers entered


            // find the average of the numbers + Note use of double so we can have decimal places
            double numAverage = numSum / numCycle;

            Console.WriteLine("The sum is: " + numSum);
            Console.WriteLine("The average is: " + numAverage);

            Console.WriteLine("Please press enter to close the program");
            Console.ReadLine();



        }
    }
}
