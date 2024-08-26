using System;
using System.Collections.Generic;
using System.Web;  // Give access to the systems generic collections classes


namespace Dictonary_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***************************************************************
             * Example use of a Dictionary
             * ************************************************************/

            // Create a Dictionary for relate zipcodes people live in
            //
            // Key - PersonsName - Unique id for an entry
            //(string)
            //
            // value - ZipCode - data associated with the key
            // (int)
            //
            // Syntax: Dictionary<key-type, value-type> = new Dictionary<key-type, value-type>

          // data-type<key-type, value-type>   = new data-type<key-type, value-type>();
            Dictionary<string, int> personInfo = new Dictionary<string, int>();

            // Add some people and their zip codes
            //
            // dictionaryName[key] = value
            //
            // dictionaryName.Add(key, value)

            personInfo["Frank"] = 85339;
            personInfo["Evan"]  = 48009;
            personInfo["Josh"]  = 15658;
            personInfo["Ryan"]  = 49116;

            personInfo.Add("Jenna", 85339);

            // specifying a key that exists in the Dictionary
            // when using [], the entry for the key is updated
            
            
                personInfo["Frank"] = 44143;

            // when using the .Add() an exception is thrown if Key already exists
            // To avoid and still use .Add(), check to see if the key already 
            //    esixts in the diftionary and only do the .Add() if it is not
            if (!personInfo.ContainsKey("Frank"))
            {
                personInfo.Add("Frank", 06082);
            }
            else
            {
                personInfo["Frank"] = 06082;
            }
            Console.WriteLine("Josh lives in: " + personInfo["Josh"]);

            Console.WriteLine("Whose zip code would you like? ");
            string name = Console.ReadLine();

            try
            {
                Console.WriteLine(name + " lives in: " + personInfo[name]);
            }
            catch (KeyNotFoundException exceptionInfo)
            {
                Console.WriteLine("Error looking for " + name);
                Console.Write(exceptionInfo.Message);
            }

            // if you want to walk through the entire Dictionary with a for-each
            //    you need to get all the keys in the Dictionary
            // use the KeyValuePair object in the foreach
            //
            // KeyValuePair<key-type, value-type> name-for-Dictionary-entry
            foreach(KeyValuePair<string, int> anEntry in personInfo)
            {
                Console.WriteLine(anEntry.Key + " lives in zip code " + anEntry.Value);
            }

        }
    }
}
