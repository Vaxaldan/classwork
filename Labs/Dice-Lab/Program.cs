﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace Dice_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Please enter how many sides the dice have."); 
            int dieSides = int.Parse(Console.ReadLine());                    
            bool keepPlaying = true;                                         

            while (keepPlaying == true) 
            {
                int dieOne = random.Next(1, dieSides + 1);
                int dieTwo = random.Next(1, dieSides + 1);
                int dieSum = dieOne + dieTwo;
               
                Console.WriteLine("Would you like to roll the dice? (yes/no)");
                string userInput = Console.ReadLine();

                if (userInput != "yes")
                {
                    keepPlaying = false;
                }
                else if (userInput == "yes" && dieSum == 2 || dieSum == 3 || dieSum == 12)
                {
                    Console.WriteLine("You rolled " + dieOne + ", " + dieTwo + ", " + "Craps!");

                    if (userInput == "yes" && dieOne == 1 && dieTwo == 1)
                    {
                        Console.WriteLine("Snake Eyes!");
                    }
                    else if (dieOne == 1 && dieTwo == 2 || dieOne == 2 && dieTwo == 1)
                    {
                        Console.WriteLine("Ace Duce!");
                    }
                    else if (dieOne == 6 && dieTwo == 6)
                    {
                        Console.WriteLine("Box Cars!");
                    }
                }
                else if (userInput == "yes" && dieSum == 3)
                {
                    Console.WriteLine("Ace Duce!");
                }
                else if (userInput == "yes" && dieSum == 7 || dieSum == 11)
                {
                    Console.WriteLine("You rolled " + dieOne + ", " + dieTwo + ", Win!");
                }
                else if (userInput == "yes" && dieSum == 3 || dieSum == 4 || dieSum == 5 || dieSum == 6 || dieSum == 8 || dieSum == 9 || dieSum == 10)
                {
                    Console.WriteLine("You rolled " + dieOne + ", " + dieTwo);
                 }
            }
        }
    }
}