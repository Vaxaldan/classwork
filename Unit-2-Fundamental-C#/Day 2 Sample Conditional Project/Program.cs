using System;
using System.Diagnostics.Eventing.Reader; //gives access to C# system stuff


namespace Day_2_Sample_Conditional_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for an odd number between 11 and 17
            //verify they have entered a correct value
            //
            // A number is odd if it is not evenly dvisible by 2
            //   (is we divide it by 2 and the remainer is not 0, it's odd)
            //
            // C# has the modulus operator (%) which provides the remainder after the divide


            Console.WriteLine("Please eneter an odd number between 11 and 17");
            int theNum = int.Parse(Console.ReadLine()); //gets user input and converts to an int

            // Show the user what we got from them
            Console.WriteLine("You enetered: " + theNum);

            // Verify the number is between 11 and 17
            if (theNum >= 11 && theNum <= 17 && theNum % 2 != 0)
            {
                Console.WriteLine("The value IS between 11 and 17 and is ODD");
            }
            else if (theNum >= 11 && theNum <= 17 && theNum % 2 == 0)
            { 
                Console.WriteLine("The value IS between 11 and 17 and is NOT ODD");
            }
            else
            { 
                Console.WriteLine("The value IS NOT between 11 and 17");
            }
            

            // Make visual studio keep the console windo open until we are done
            Console.WriteLine("Please press eneter to end the program.");
            Console.ReadLine();

        
        }
    }
}
