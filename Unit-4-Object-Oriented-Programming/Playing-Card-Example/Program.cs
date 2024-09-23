using System;
using GeneralPurposeFunctions;


namespace Playing_Card_Example
{



    internal class Program
    {
       
        
        static CommonlyUsedFunctions myFuncs= new CommonlyUsedFunctions();

        // This is the application program Main()
        // 
        // It will instantiate and manipulate objects of various classes
        static void Main(string[] args)
        {
            myFuncs.WriteSeparatorLine("Welcome to our first OOP Example!");

            // Instanciate a PlayingCard - an Ace of Hearts which is red

            myFuncs.WriteSeparatorLine("Instanciate and display a PlayinCard");
            // data-type name = new data-type(intializers)
            PlayingCard aCard = new PlayingCard(1, "Hearts", "Red");

            Console.WriteLine("aCard is: " + aCard);
            // Console.WriteLine expects a string to be written
            // Interpolation ($"") - generates a string
            // aCard is aPlayingCard type, not a string
            // In order for it to be written it needs to be converted to a string
            // The default method to convert an Object to a string generates
            //             a string containing the "namespace.className"
            // If you want your class objects to be representd as a string
            //    you must override the default ToString() methid in your class
            //    i.e. you decide what a string representation of your class looks like

            PlayingCard newCard = aCard;
            Console.WriteLine("aCard is: " + aCard);
            Console.WriteLine("newCard is: " + newCard);

            // Change the value in newCard to be a two

            myFuncs.WriteSeparatorLine("Change value in newCard to 2");
            newCard.CardValue = 2;
            Console.WriteLine("newCard is: " + newCard);




            myFuncs.PauseProgram();
                
             
        }
    }
}
