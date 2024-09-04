using System;

namespace StarTrekStuff
{
    public class StarFleetPersonnel
    {
        // Data associated with the class
        //
        // Access modifier indicates who has access to the item'
        //
        //    public  - anyone with an object of the clas
        //    private - only methods in the class have access (no one outside the class)

//      access data
//     modifer type   variable-name
        public string name;
        public string rank;
        public string assignment;


        // Methods associated with the class
        // Typically a class has one or more constructors
        //
        // Since a class is programmer defined data type, the programmer must 
        //               define how it is to be initialized
        //
        // A constructor a method that initialize an object when it is instantiated/create
        //
        // A constructor has no return type and has name as the class
        //               may receive parameters used to initialize a new object
        //
        // The constructor's job is to assign values to the data for the class
        //
        // 3-arg constructor - it receives 3 values used to initialize a new object
        public StarFleetPersonnel(string personName, string theirRank, string theirAssignment)
        {
            name       = personName;
            rank       = theirRank;
            assignment = theirAssignment;
        }

        // For demonstration purposes - we'll add a default/0-arg constructor
        //public StarFleetPersonnel()
        //{
        //    name = "yourself";         // Default name of a StarFleet person
        //    rank = "Cat";              // Default rank
        //    assignment = "Bartender";  // Default assignment
        //}

        // Additional methods to support the class
        //   (aka Member Methods)

        /************************************************************************************
         * Display a line from the object parsed into individual values
         ************************************************************************************/
        public void DisplayCrewMember()
        {
            Console.WriteLine($"\nName:\t{name}\nCrew:\t{assignment}\nRank:\t{rank}");
        } // End of DisplayLine()


    } // End of class StarFleetPersonnel
}  // End of namespace StarTrekStuff