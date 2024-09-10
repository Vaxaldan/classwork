using GeneralPurposeFunctions;
using System;


namespace Day_3_Inheritance
{
    internal class Program
    {
        // Instantiate a copy of the code in CommonlyUsedFunctions called myFuncs
        // It's static because its used in Main() which is static
        static CommonlyUsedFunctions myFuncs = new CommonlyUsedFunctions();

        // This is the application program - Main()
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
            newCard.CardValue = 2;       // Use property to change the value
            Console.WriteLine($"newCard is: {newCard}");
            Console.WriteLine($"  aCard is: {aCard}");

            /*******************************************************************************
             * Day-4 Inheritance usage start here
             ******************************************************************************/

            /*******************************************************************************
             * American PlayingCard Usage Examples
             ******************************************************************************/

            myFuncs.WriteSeparatorLine("Instantiate an AmericanPlayingCard and display it");

            // Instantiate a subclass object using subclass ctor
            AmericanPlayingCard theCard = new AmericanPlayingCard(10, "Spades");
            
            // This will use the PlayingCard ToString() method to convert theCard to a string
            // Since the AmericanPlayingCard does not have a ToString() method override
            //      when C# needs to ger a string representation of an AmericanPlayingCard
            //      it will use the ToString() in its base class
            //      (or the generic Object ToString() if base class doesn't have one)

            Console.WriteLine($"theCard: {theCard}");

            AmericanPlayingCard theCard2 = new AmericanPlayingCard(10, "Spades");

            // This will use the PlayingCard .Equals() method
            // Since the AmericanPlayingCard does not have a Equals() method override
            //      when C# needs to use an Equals() method for an AmericanPlayingCard
            //      it will use the Equals() in its base class
            //      (or the generic Object Equals() if base class doesn't have one)
            if (theCard.Equals(theCard2))
            {
                Console.WriteLine("They are EQUAL");
            }
            else
            {
                {
                    Console.WriteLine("They are NOT equal");
                }
            }
            
            myFuncs.WriteSeparatorLine("Instantiate and display a valid AmericanPlayingCard - 13 of Clubs");

            // Define an AmericanPlayingCard
            AmericanPlayingCard usaCard1 = new AmericanPlayingCard(13, "Clubs");

            usaCard1.ShowCard();

            myFuncs.WriteSeparatorLine("Instantiate and display an invalid AmericanPlayingCard - 14 of C#");

            // Define an AmericanPlayingCard
            AmericanPlayingCard usaCard2 = new AmericanPlayingCard(14, "C#");

            usaCard2.ShowCard();

            myFuncs.WriteSeparatorLine("Display AmericanPlayingCard using base class ToString()");

            Console.WriteLine(usaCard1);
            Console.WriteLine(usaCard2);

            myFuncs.WriteSeparatorLine("Compare two AmericanPlayingCards");

            Console.Write($"1st card: {usaCard1.CardValue} ({usaCard1.GetCardValueName()}) of {usaCard1.CardSuit}");
            
            Console.Write($"{(usaCard1.Equals(usaCard2) ? " is EQUAL" : " is NOT equal")} to");

            Console.Write($" 2nd card: {usaCard2.CardValue} ({usaCard2.GetCardValueName()}) of {usaCard2.CardSuit}\n");

            myFuncs.PauseProgram();

            /*******************************************************************************
             * ItalianPlayingCard Usage Examples
             ******************************************************************************/

            myFuncs.WriteSeparatorLine("Instantiate and display a valid ItalianPlayingCard - 13 of Coins");

            // Define an ItalianPlayingCard
            ItalianPlayingCard italianCard1 = new ItalianPlayingCard(13, "Coins");

            italianCard1.ShowCard();

            myFuncs.WriteSeparatorLine("Instantiate and display an invalid ItalianPlayingCard - 8 of C#");

            // Define an ItalianPlayingCard
            ItalianPlayingCard italianCard2 = new ItalianPlayingCard(8, "C#");

            italianCard2.ShowCard();

            myFuncs.WriteSeparatorLine("Display ItalianPlayingCard using base class ToString()");

            Console.WriteLine(italianCard1);
            Console.WriteLine(italianCard2);

            myFuncs.WriteSeparatorLine("Compare two ItalianPlayingCards");

            Console.Write($"1st card: {italianCard1.CardValue} ({italianCard1.GetCardValueName()}) of {italianCard1.CardSuit}");

            Console.Write($"{(italianCard1.Equals(italianCard2) ? " is EQUAL" : " is NOT equal")} to");

            Console.Write($" 2nd card: {italianCard2.CardValue} ({italianCard2.GetCardValueName()}) of {italianCard2.CardSuit}\n");

            myFuncs.PauseProgram();

            /*******************************************************************************
             * SwissPlayingCard Usage Examples
             ******************************************************************************/

            myFuncs.WriteSeparatorLine("Instantiate and display a valid SwissPlayingCard - 13 of Acorns");
           
            // Define an SwissPlayingCard
            SwissPlayingCard SwissCard1 = new SwissPlayingCard(13, "Acorns");

            SwissCard1.ShowCard();

            myFuncs.WriteSeparatorLine("Instantiate and display an invalid SwissPlayingCard - 2 of C#");

            // Define an SwissPlayingCard
            SwissPlayingCard SwissCard2 = new SwissPlayingCard(2, "C#");

            SwissCard2.ShowCard();

            myFuncs.WriteSeparatorLine("Display SwissPlayingCard using base class ToString()");

            Console.WriteLine(SwissCard1);
            Console.WriteLine(SwissCard2);

            myFuncs.WriteSeparatorLine("Compare two SwissPlayingCards");

            Console.Write($"1st card: {SwissCard1.CardValue} ({SwissCard1.GetCardValueName()}) of {SwissCard1.CardSuit}");

            Console.Write($"{(SwissCard1.Equals(SwissCard2) ? " is EQUAL" : " is NOT equal")} to");

            Console.Write($" 2nd card: {SwissCard2.CardValue} ({SwissCard2.GetCardValueName()}) of {SwissCard2.CardSuit}\n");

            myFuncs.WriteSeparatorLine("Instantiate and display default cards of all sub classes");

            AmericanPlayingCard defaultUsaCard    = new AmericanPlayingCard();
            ItalianPlayingCard defaultItalianCard = new ItalianPlayingCard();
            SwissPlayingCard defaultSwissCard     = new SwissPlayingCard();

            defaultSwissCard.ShowCard();
            defaultUsaCard.ShowCard();
            defaultItalianCard.ShowCard();

            myFuncs.WriteSeparatorLine("Thanks for trying out our first OOP application!");
            myFuncs.PauseProgram();
        }
    }
}

