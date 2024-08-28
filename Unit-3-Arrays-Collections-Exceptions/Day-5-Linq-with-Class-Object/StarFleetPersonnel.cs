using System;
using System.Security.Policy;

namespace StarTrekStuff
{
    public class StarFleetPersonnel
    {
        public string Name { get;}
        public string Rank { get;}
        public string Assignment { get;}

        public StarFleetPersonnel() {}

        public StarFleetPersonnel(string personName, string theirRank, string theirAssignment)
        {
            Name       = personName;
            Rank       = theirRank;
            Assignment = theirAssignment;
        }


        /************************************************************************************
         * Display a line from the list parsed into individual values
         ************************************************************************************/
        public void DisplayCrewMember()
        {
            Console.WriteLine($"\nName:\t{Name}\nCrew:\t{Assignment}\nRank:\t{Rank}");

        } // End of DisplayLine()


    } // End of class StarFleetPersonnel
}  // End of namespace StarTrekStuff