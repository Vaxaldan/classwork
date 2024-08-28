using System;                      // Give me access to C# System
using System.Collections.Generic;  // Give me access to C# Collections stuff
using System.Linq;                 // Give me access to the LINQ

namespace Day_4_Linq_Lambda_Expressions_Example
{
    internal class Program
    {
        // Data defined outside of any method (including Main())
        // Still inside the class Program
        // This way it is available and shared by all methods
        //      (instead of passing as a parameter to methods that need access to it)
        // It must be made static because it's used in static methods like Main()
        static List<string> starFleetPersonnel = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linq/Lambda Expression Demo");

            // Call a method to load the List that holding our data
            LoadData();

            WriteSeparatorLine("List of People in our List");

            foreach (string anElement in starFleetPersonnel)
            {
                DisplayLine(anElement);
            }

            WriteSeparatorLine("Find an Entry");

            while (true)
            {
                if (!moreInput())
                {
                    break;
                }

                Console.Write("\nEnter value to search for: ");
                string searchString = Console.ReadLine();

                // Search the List for matching elements based on user input
                //        using standard C# coding elements
                //
                //int matchCount = 0;
                //         name-of-curr-item in this-list
                //foreach (string anEntry    in starFleetPersonnel)
                //{
                //    if (anEntry.ToLower().Contains(searchString.ToLower()))
                //    {
                //        matchCount++;
                //        DisplayLine(anEntry);
                //    }
                //}

                // Search the List for matching elements based on user input
                //        using LINQ Where() method
                //
                // Syntax:  Where(name-of-curr-item => condition-using-name-of-curr-item)
                //
                // a foreach loop is implied by the Where()
                //           it will go through the list one item at a time assign the item
                //                                       to the name to the left of the =>
                //
                // List name is implied from being to the left of .Where()
                //
                //
                // The variable specified to left of the = will contain all entries
                //              from the List that made the condition true
                //
                // Note use of var type to hold the result of .Where()

                var matchingEntries =
                    starFleetPersonnel.Where(anEntry => anEntry.ToLower().Contains(searchString.ToLower()));

                // At this point the matchingEntries variable hold all List entries that match the condition

                Console.WriteLine(("\n" + matchingEntries.Count()) + " entries found matching \'" + searchString + "\'");

                // Loop through the result and display the entries
                foreach (string aPerson in (matchingEntries))  // Note: Cast to type of original List
                {
                    DisplayLine(aPerson);
                }
            } // End of While-loop for searching for lines

            // Display the item in the List that matches a user specified value

            // Define a variable to hold what the user wants
            Console.WriteLine("Please enter the value of want you want me to search for: ");
            string whatTheyWant = Console.ReadLine();

            // Use the LINQ First() method to search the List for the first occurence of what they want
            // FirstOrDefault() is safer since something is always returned
            // First() will throw an Exception if there is no match in the List
            //var theFirstOne = starFleetPersonnel.First(aLine => aLine.ToUpper().Contains(whatTheyWant.ToUpper()));
            var theFirstOne = starFleetPersonnel.FirstOrDefault(aLine => aLine.ToUpper().Contains(whatTheyWant.ToUpper()));

            Console.WriteLine($"\nThe first occurence of {whatTheyWant} is in: " + ((theFirstOne != null) ? theFirstOne : "None"));


            // Find only unique occurrences from user request
            // Define a variable to hold what the user wants
            Console.WriteLine("Please enter the value of want you want me to search for: ");
            string uniqueSearch = Console.ReadLine();

            // Use the LINQ Single() method to search the List a unique occurence of what they want
            // SingleOrDefault() is safer since something is always returned
            // Single() will throw an Exception if there is no unique occurance
            //var theOnlyOne = starFleetPersonnel.Single(aLine => aLine.ToUpper().Contains(whatTheyWant.ToUpper()));
            try
            {
                var theOnlyOne =
                    starFleetPersonnel.SingleOrDefault(aLine => aLine.ToUpper().Contains(uniqueSearch.ToUpper()));

                Console.WriteLine($"\nThe only occurence of {whatTheyWant} is in: " + ((theOnlyOne != null) ? theOnlyOne : "is not in the List"));
            }
            catch (Exception exceptionInfo)
            {
                Console.WriteLine($"\n!!!!! Uh-Oh Uh-Oh Uh-Oh !!!!!\n {exceptionInfo.Message}\n!!!!! Uh-Oh Uh-Oh Uh-Oh !!!!");
            }

            WriteSeparatorLine("Sorting the List");

            // Sort the List
            var sortList = starFleetPersonnel.OrderBy(aline => aline);

            foreach (string aLine in sortList)
            {
                Console.WriteLine(aLine);
            }



            Console.WriteLine("\nThanks for trying out the Linq/Lambda Expression Demo");
            PauseProgram();

        } // End of Main()

        /************************************************************************************
         * Load List with sample data
         ************************************************************************************/
        static public void LoadData()
        {
            // .Add() - add to a List

            starFleetPersonnel.Add("James T Kirk, Captain, NCC-1701");
            starFleetPersonnel.Add("Jean Luc Picard, Captain, NCC-1701-D");
            starFleetPersonnel.Add("Jonathan Archer, Captain, NX-01");
            starFleetPersonnel.Add("Catherine Janeway, Captain, NCC-74656");
            starFleetPersonnel.Add("Benjamin Sisco, Captain, DS9");
            starFleetPersonnel.Add("Worf Son of Mogh, Lieutenant, NCC-1701-D");
            starFleetPersonnel.Add("Miles O'Brian, Senior Chief, Deep Space 9");
            starFleetPersonnel.Add("Kira Nerys, Colonel, Deep Space 9");
            starFleetPersonnel.Add("Jadzi Dax, Lt. Commander, Deep Space 9");
            starFleetPersonnel.Add("Odo, Constable, Deep Space 9");
            starFleetPersonnel.Add("Montgomery Scott, Commander, NCC-1701");
            starFleetPersonnel.Add("S'chn T'gai Spock, Commander, NCC-1701");
            starFleetPersonnel.Add("Leonard McCoy,Lt Commander, NCC-1701");
            starFleetPersonnel.Add("Nyota Uhura, Lt Commander, NCC-1701");
            starFleetPersonnel.Add("Deanna Troi, Lt Commander, NCC-1701-D");
            starFleetPersonnel.Add("B'lanna Torres, Lt Commander, NCC-74656");
            starFleetPersonnel.Add("Chakotay, Lt Commander, NCC-74656");
            starFleetPersonnel.Add("Seven of Nine,None, NCC-74656");
            starFleetPersonnel.Add("Tuvok, Lieutenant, NCC-74656");
        } // End of LoadData()

        /************************************************************************************
         * Parse entry in List into individual values
         ************************************************************************************/
        static public void Parse(string staffInfo, out string name, out string rank, out string assignment)
        {
            string[] elements = staffInfo.Split(',');

            name = elements[0];
            rank = elements[1];
            assignment = elements[2];

        } // End of Parse()

        /************************************************************************************
         * Display a separator line block with a message
         ************************************************************************************/
        static void WriteSeparatorLine(string message)
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("----- " + message);
            Console.WriteLine("-------------------------------------\n");

        } // End of WriteSeparatorLine()

        /************************************************************************************
         * Display a line from the list parsed into individual values
         ************************************************************************************/
        static void DisplayLine(string theLine)
        {
            Parse(theLine, out string personName, out string rank, out string stationed);
            Console.WriteLine($"\nName:\t{personName}\nCrew:\t{stationed}\nRank:\t{rank}");

        } // End of DisplayLine()

        /************************************************************************************
         * Pause program until user presses the enter key
         ***********************************************************************************/
        static void PauseProgram()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        } // End of PauseProgram()

        /************************************************************************************
         * return a boolean value to indicate if the user has more input
         ************************************************************************************/
        static bool moreInput()
        {
            bool isThereInput = false;  // Hold teh return value 

            string whatUserTyped = "";     // Hold what the user enters

            bool getInput = true;   // Control the user interaction loop

            do
            {
                // Ask the user if they have any numbers to enter (Y/N)
                Console.WriteLine("\nDo you have any values to enter (Y/N)?");
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

        }  // End of moreInput()

    } // End of class Program
} // End of namespace
