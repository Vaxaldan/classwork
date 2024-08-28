using System;
using System.Security.Policy;

namespace StarTrekStuff
{
    public class StarFleetPersonnel
    {
        public string name;
        public string rank;
        public string assignment;

        public StarFleetPersonnel(string personName, string theirRank, string theirAssignment)
        {
            name       = personName;
            rank       = theirRank;
            assignment = theirAssignment;
        }


        /************************************************************************************
         * Display a line from the list parsed into individual values
         ************************************************************************************/
        public void DisplayCrewMember()
        {
            Console.WriteLine($"\nName:\t{name}\nCrew:\t{assignment}\nRank:\t{rank}");
        } // End of DisplayLine()


    } // End of class StarFleetPersonnel
}  // End of namespace StarTrekStuff