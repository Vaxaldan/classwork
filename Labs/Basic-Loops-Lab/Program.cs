using System;


namespace Basic_Loops_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use a do-while loop to output "Hello, World!" in a loop. Each time you output "Hello, World!" ask the user whether they would like to continue
            string userInput = Console.ReadLine();
            do
            {
                Console.WriteLine("Hello, World!");
                Console.WriteLine("Would you like to continue?");
                Console.ReadLine();

            }while (userInput == "no");
        }
    }
}
