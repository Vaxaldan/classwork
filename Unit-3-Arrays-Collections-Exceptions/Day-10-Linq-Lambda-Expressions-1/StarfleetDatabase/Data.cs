using System;
using System.Collections.Generic;

namespace StarfleetDatabase

{
    class StarFleetDatabase
    {
        List<string> StarFleetPersonnel = new List<string>();
        
        public void LoadData()
        {
            StarFleetPersonnel.Add("James T Kirk, Captain, NCC-1701");
            StarFleetPersonnel.Add("Jean Luc Picard, Captain, NCC-1701-D");
            StarFleetPersonnel.Add("Jonathan Archer, Captain, NX-1");
            StarFleetPersonnel.Add("Catherine Janeway, Captain, NCC-74656");
            StarFleetPersonnel.Add("Benjamin Sisco, Captain, DS9");
            StarFleetPersonnel.Add("Worf Son of Mogh, Lieutenant, NCC-1701-D");
            StarFleetPersonnel.Add("Miles O'Brian. Senior Chief, Deep Space 9");
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
        }

        public List<string> getAllData()
        {
            return StarFleetPersonnel;
        }

        public void Parse(string staffInfo, out string name, out string rank, out string assignment)
        {
            string[] elements = staffInfo.Split(",");

            name       = elements[0]; 
            rank       = elements[1]; 
            assignment = elements[2];

        }

    } // End of class Program
} // End of namespace
