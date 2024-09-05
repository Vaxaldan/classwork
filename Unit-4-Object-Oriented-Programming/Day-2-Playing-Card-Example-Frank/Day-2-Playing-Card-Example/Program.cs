using System;
using GeneralPurposeFunctions;   // Give me access to the GeneralPurposeFunction Code


namespace Day_2_Playing_Card_Example
{
    internal class Program
    {
        // Instantiate a copy of the code in CommonlyUsedFunctions
        //         called myFuncs
        // It's static because its used in Main() whichis static
        static CommonlyUsedFunctions myFuncs = new CommonlyUsedFunctions();

        // This is the application program 0 Main()
        //
        // It will instantiate and manipulate objects of various classes

        static void Main(string[] args)
        {
            myFuncs.WriteSeparatorLine("Welcome to our first OOP Example");

            /*************************************************************************
             * Define/Instantiate a PlayingCard - an Ace of Hearts which is red
             *************************************************************************/
            myFuncs.WriteSeparatorLine("Instantiate and display a PlayingCard");

     //      data-type  name  = new data-type(initializers)
            PlayingCard aCard = new PlayingCard(1, "Hearts", "Red");

            Console.WriteLine($"aCard is: {aCard}");  // Display the PlayingCard
                                                      // Console.WriteLine expects a string to be written
                                                      // Interpolation ($"") - generates a string
                                                      // aCard is aPlayingCard type not a string
                                                      // In order for it to written it needs to be converted to a string
                                                      // The default ToString() method to convert an Object to a string generates
                                                      //             a string containing the "namespace.className"
                                                      // If you want your class object to be represented as string
                                                      //    YOU must override the default ToString() method in your class
                                                      // i.e. YOU decide what a string representation of your class looks like

            /*************************************************************************
             * Define/Instantiate a new PlayingCard to be the same as aCard
             *     and display them both
             *************************************************************************/

         // PlayingCard newCard = aCard;  // This makes both newCard and aCard point to the same object
            PlayingCard newCard = new PlayingCard(aCard); // Use copy constructor

            Console.WriteLine($"  aCard is: {aCard}");
            Console.WriteLine($"newCard is: {newCard}");

            /*************************************************************************
             * Change the value in newCard to be a two
             *************************************************************************/
            myFuncs.WriteSeparatorLine("Change value in newCard to 2");
        //  newCard.cardValue = 2;   // Cannot access private data in an object
            newCard.CardValue = 2;   // Use property to change the value
            Console.WriteLine($"newCard is: {newCard}");
            Console.WriteLine($"  aCard is: {aCard}");


            myFuncs.PauseProgram();
        }
    }
}
