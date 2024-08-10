using System;

namespace Basic_Loops_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use a do-while loop to output "Hello, World!" in a loop. Each time you output "Hello, World!" ask the user whether they would like to continue
            string userInput;
            

            do
            {                
                
                Console.WriteLine("Hello, World!");
                Console.WriteLine("Would you like to continue? (yes/no)");
                userInput = Console.ReadLine();

                if (userInput == "no")
                {
                    continue; //skips to the end of the loop and checks the while condition
                }

            } while (userInput != "no"); //will loop as long as the user input doesn't type no

            // Prompt the user for a number. Use a for loop to output all the numbers from that number to 0. After that loop finishes, use another loop to output all the numbers from 0 to that number.



            /*

            for (int i = 0; i < int.Parse(Console.ReadLine()); i++)
            {
                
                Console.WriteLine("Please enter a number");
                int userNum = int.Parse(Console.ReadLine());
                
            }
             
            */


            // Keypad entry 13579

            bool doorLock = true;
            int userAttempt = 0;

            while (doorLock == true)
            {
                
                

                Console.WriteLine("Please enter the key code. (5 numbers)");
                int userCode = int.Parse(Console.ReadLine());
               
                if(userCode == 13579)
                {
                   Console.WriteLine("Welcome!");
                    doorLock = false;
                }

                else if(userCode != 13579)
                {
                    userAttempt++;
                    Console.WriteLine("Incorrect key code " + userAttempt);
                    
                }
                
                else if(userAttempt == 5)
                {
                    Console.WriteLine("WARNING, to many incorrect attempts. ");
                }
            }
        }
    }
}
