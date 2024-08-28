using System;
using System.Collections.Generic;
using System.Linq;
using GeneralPurposeFunctions;
using StarTrekStuff;

namespace Day_5_Linq_with_Class_Object
{
    internal class Program
    {
        // Data defined outside of any method (including Main())
        // Still inside the class Program
        // This way it is available and shared by all methods
        //      (instead of passing as a parameter to methods that need access to it)
        // It must be made static because it's used in static methods like Main()

        static CommonlyUsedFunctions commonCode = new CommonlyUsedFunctions();

        static List<StarFleetPersonnel> castOfPeople = new List<StarFleetPersonnel>();

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Linq/Lambda Expression Demo");

            // Call a method to load the List that holding our data
            LoadData();

            commonCode.WriteSeparatorLine("List of People in our List");

            foreach (StarFleetPersonnel aPerson in castOfPeople)
            {
               aPerson.DisplayCrewMember();
            }

            commonCode.WriteSeparatorLine("Find an Entry");

            while (true)
            {
                if (!commonCode.moreInput())
                {
                    break;
                }

                Console.Write("\nEnter Name of the person to search for: ");
                string searchString = Console.ReadLine();

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
                    castOfPeople.Where(anEntry => anEntry.name.ToLower().Contains(searchString.ToLower()));

                // At this point the matchingEntries variable hold all List entries that match the condition

                Console.WriteLine(("\n" + matchingEntries.Count()) + " entries found matching \'" + searchString +
                                  "\'");

                // Loop through the result and display the entries
                foreach (StarFleetPersonnel aPerson in (matchingEntries)) // Note: Cast to type of original List
                {
                    aPerson.DisplayCrewMember();
                }
            } // End of While-loop for searching for lines

            commonCode.WriteSeparatorLine("Sorting the List");

            // Sort the List
            var sortList = castOfPeople.OrderBy(aline => aline.rank);

            foreach (StarFleetPersonnel aLine in sortList)
            {
                aLine.DisplayCrewMember();
            }

            Console.WriteLine("\nThanks for trying out the Linq/Lambda Expression Demo");
            commonCode.PauseProgram();

        } // End of Main()

        /************************************************************************************
         * Load List with sample data
         ************************************************************************************/
        static void LoadData()
        {
            castOfPeople.Add(new StarFleetPersonnel("James T Kirk", "Captain", "NCC-1701"));
            castOfPeople.Add(new StarFleetPersonnel("Jean Luc Picard", "Captain", "NCC-1701-D"));
            castOfPeople.Add(new StarFleetPersonnel("Jonathan Archer", "Captain", "NX-01"));
            castOfPeople.Add(new StarFleetPersonnel("Catherine Janeway", "Captain", "NCC-74656"));
            castOfPeople.Add(new StarFleetPersonnel("Benjamin Sisco", "Captain", "DS9"));
            castOfPeople.Add(new StarFleetPersonnel("Worf Son of Mogh", "Lieutenant", "NCC-1701-D"));
            castOfPeople.Add(new StarFleetPersonnel("Miles O'Brian", "Senior Chief", "Deep Space 9"));
            castOfPeople.Add(new StarFleetPersonnel("Kira Nerys", "Colonel", "Deep Space 9"));
            castOfPeople.Add(new StarFleetPersonnel("Jadzi Dax", "Lt. Commander", "Deep Space 9"));
            castOfPeople.Add(new StarFleetPersonnel("Odo", "Constable", "Deep Space 9"));
            castOfPeople.Add(new StarFleetPersonnel("Montgomery Scott", "Commander", "NCC-1701"));
            castOfPeople.Add(new StarFleetPersonnel("S'chn T'gai Spock", "Commander", "NCC-1701"));
            castOfPeople.Add(new StarFleetPersonnel("Leonard McCoy", "Lt Commander", "NCC-1701"));
            castOfPeople.Add(new StarFleetPersonnel("Nyota Uhura", "Lt Commander", "NCC-1701"));
            castOfPeople.Add(new StarFleetPersonnel("Deanna Troi", "Lt Commander", "NCC-1701-D"));
            castOfPeople.Add(new StarFleetPersonnel("B'lanna Torres", "Lt Commander", "NCC-74656"));
            castOfPeople.Add(new StarFleetPersonnel("Chakotay", "Lt Commander", "NCC-74656"));
            castOfPeople.Add(new StarFleetPersonnel("Seven of Nine" ,"None", "NCC-74656"));
            castOfPeople.Add(new StarFleetPersonnel("Tuvok", "Lieutenant", "NCC-74656"));
        } // End of LoadData()

    } // End of class Program
} // End of namespace

