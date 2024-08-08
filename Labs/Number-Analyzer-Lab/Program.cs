using System;
using System.Diagnostics.Eventing.Reader;


namespace Number_Analyzer_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! What is your name?");
            string user = Console.ReadLine(); // gets and stores the user's name

            Console.WriteLine(user + ", please enter a number between 1 and 100.");
            int userInput = int.Parse(Console.ReadLine()); // gets and stores the user's unput and converts it to int

            Console.WriteLine(user + ", you enetered " + userInput);

            if (userInput < 1 || userInput > 100)
            {
                Console.WriteLine(user + ", you enetered an invalid number");
            }
            else if (userInput >= 1 && userInput < 60 && userInput % 2 != 0) // checks to see if user's number is less greater than or equal to 1, less than 60 and if it is odd
            {
                Console.WriteLine(user + " ," + userInput + ", is odd and less than 60.");
            }
           
            else if (userInput >= 2 && userInput <= 24 && userInput % 2 == 0) // checks if user's number is greater than or equal 2, and less than or equal to 24 and if it is even
            {
                Console.WriteLine(user + " ," + userInput + " is even and less than 25.");
            }
            else if (userInput >= 26 && userInput <= 60 && userInput % 2 == 0) // checks if user's number is greater than or equal to 26, and less than or equal to 60 and if it is even
            {
                Console.WriteLine(user + " ," + userInput + " is even and between 26 and 60 inclusive.");
            }
            else if (userInput > 60 && userInput % 2 == 0) // checks if the user's number is greater than 60 and if it is even
            {
                Console.WriteLine(user + " ," + userInput + " is even and greater than 60");
            }
            else if (userInput > 60 && userInput % 2 != 0) // checks if the user's number is greater than 60 and if it is odd
            {
                Console.WriteLine(user + " ," + userInput + " is odd and greater than 60");
            }


            Console.WriteLine("Please press ENTER to end program.");  //keeps visual studio open at the end of the program
            Console.ReadLine();

        }
    }
}
