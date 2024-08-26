using System;
using System.Collections.Generic;

namespace Day_4_Linq_Lambda_Expressions_Example
{
    internal class Program
    {
        static List<string> StarFleetPersonnel = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linq/Lambda Expression Demo");

            LoadData();

            WriteSeparatorLine("List of People in our List");

            foreach (string anElement in StarFleetPersonnel)
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

                int matchCount = 0;
                foreach (string anEntry in StarFleetPersonnel)
                {
                    if (anEntry.ToLower().Contains(searchString.ToLower()))
                    {
                        matchCount++;
                        DisplayLine(anEntry);
                    }
                }

                Console.WriteLine("\n" + matchCount + " entries found matching \'" + searchString + "\'");
            }

            Console.WriteLine("\nThanks for trying out the Linq/Lambda Expression Demo");
            PauseProgram();

        } // End of Main()

        /************************************************************************************
         * Load List with sample data
         ************************************************************************************/
        static public void LoadData()
        {
            StarFleetPersonnel.Add("James T Kirk, Captain, NCC-1701");
            StarFleetPersonnel.Add("Jean Luc Picard, Captain, NCC-1701-D");
            StarFleetPersonnel.Add("Jonathan Archer, Captain, NX-1");
            StarFleetPersonnel.Add("Catherine Janeway, Captain, NCC-74656");
            StarFleetPersonnel.Add("Benjamin Sisco, Captain, DS9");
            StarFleetPersonnel.Add("Worf Son of Mogh, Lieutenant, NCC-1701-D");
            StarFleetPersonnel.Add("Miles O'Brian, Senior Chief, Deep Space 9");
            StarFleetPersonnel.Add("Kira Nerys, Colonel, Deep Space 9");
            StarFleetPersonnel.Add("Jadzi Dax, Lt. Commander, Deep Space 9");
            StarFleetPersonnel.Add("Odo, Constable, Deep Space 9");
            StarFleetPersonnel.Add("Montgomery Scott, Commander, NCC-1701");
            StarFleetPersonnel.Add("S'chn T'gai Spock, Commander, NCC-1701");
            StarFleetPersonnel.Add("Leonard McCoy,Lt Commander, NCC-1701");
            StarFleetPersonnel.Add("Nyota Uhura, Lt Commander, NCC-1701");
            StarFleetPersonnel.Add("Deanna Troi, Lt Commander, NCC-1701-D");
            StarFleetPersonnel.Add("B'lanna Torres, Lt Commander, NCC-74656");
            StarFleetPersonnel.Add("Chakotay, Lt Commander, NCC-74656");
            StarFleetPersonnel.Add("Seven of Nine,None, NCC-74656");
            StarFleetPersonnel.Add("Tuvok, Lieutenant, NCC-74656");
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
