using GeneralPurposeFunctions;
using System.Transactions;

namespace Day_3_Logging
{
    internal class Program
    {
        static CommonlyUsedFunctions myFuncs = new CommonlyUsedFunctions();

        static string inputFilePath = "../../../Data/IMDB-Top-25-SciFi-Movies.txt";

        static StreamWriter logFile = null;
        static void Main(string[] args)
        {
            // Log the program start
            LogEvent("Program started");


            // Read and display all the data in the IMDB-Top_SciFi-Movies file

            // Define a StreamReader for the file
            StreamReader fileReader = new StreamReader(inputFilePath);

            // Define a List to hold each line in the file
            List<string> sciFiMovies = new List<string>();

            // Make sure we can read all the data successfully 
            while (!fileReader.EndOfStream) // Loop as long as its not the end of the stream
            {
               string line = fileReader.ReadLine();
                sciFiMovies.Add(line);
            }

            // Loop until the user indicates they are done by typing in 'N/no' when asked
            // Ask the user which movie they want from the List by a partial word search
            // Prompt the user to search for a movie
            // define a place to hold a user's choice

            while (myFuncs.moreInput())
            {



                Console.WriteLine("Please enter a word in the title of the movie you're looking for.");
                string userInput = Console.ReadLine();

                // Check to see if any movies in the list contain the users words
                // Loop through the list of movies to see if the title contains the word
                foreach (string aLine in sciFiMovies)
                {
                    if (aLine.Contains(userInput))
                    {
                        Console.WriteLine($"{aLine}");
                    }
                }
            }
            fileReader.Close(); // Release memory used by supporting data structure

            LogEvent("Program ended.");
        }

        // Helper methods for Main()
        
        // Log program events including user interactions
        public static void LogEvent(string messageToLog)
        {
            
            if (logFile == null)
            {
                logFile = new StreamWriter("../../../program.log", true);
            }
               
            DateTime currentTimeStamp = DateTime.Now;
            string formattedTime = currentTimeStamp.ToString("yyy-mm-dd-HH:mm:ss");

            logFile.WriteLine($"{formattedTime} - {messageToLog}");
            logFile.Flush();
        }


    }
}
