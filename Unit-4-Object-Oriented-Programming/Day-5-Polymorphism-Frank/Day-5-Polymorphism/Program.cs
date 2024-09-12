using GeneralPurposeFunctions;
using System;
using System.CodeDom;
using System.Collections.Generic;


namespace Day_5_Polymorphism
{
    internal class Program
    {
        // This is the application program - Main()
        //
        // It will instantiate and manipulate objects of various classes

        // Instantiate a copy of the code in CommonlyUsedFunctions called myFuncs
        // It's static because its used in Main() which is static
        static CommonlyUsedFunctions myFuncs = new CommonlyUsedFunctions();

        static void Main(string[] args)
        {
            myFuncs.WriteSeparatorLine("Welcome to The Polymorphism Example!");

            /*************************************************************************
             * Define/Instantiate a PlayingCard - an Ace of Hearts which is red
             *************************************************************************/
            myFuncs.WriteSeparatorLine("Instantiate and display some PlayingCard objects");

            //      data-type  name  = new data-type(initializers)
            PlayingCard aCard = new PlayingCard(1, "Hearts", "Red");

            /*************************************************************************
             * Define/Instantiate a new PlayingCard to be the same as aCard
             *     and display them both
             *************************************************************************/

            // PlayingCard newCard = aCard;  // This makes both newCard and aCard point to the same object
            PlayingCard newCard = new PlayingCard(aCard); // Use copy constructor

            PlayingCard anotherCard = new PlayingCard(13, "Hearts", "Red");

            Console.WriteLine($"      aCard is: {aCard}");
            Console.WriteLine($"    newCard is: {newCard}");
            Console.WriteLine($"anotherCard is: {anotherCard}");

            myFuncs.WriteSeparatorLine("Compare the PlayingCard objects to see if equal");
          
            DisplayIfCardsAreEqual(aCard, newCard);
            DisplayIfCardsAreEqual(aCard, anotherCard);

            /*******************************************************************************
             * American PlayingCard Usage Examples
             ******************************************************************************/
            myFuncs.WriteSeparatorLine("Instantiate some AmericanPlayingCard objects and display them");

            AmericanPlayingCard usaCard1 = new AmericanPlayingCard(10, "Spades");
            AmericanPlayingCard usaCard2 = new AmericanPlayingCard(10, "Spades");
            AmericanPlayingCard usaCard3 = new AmericanPlayingCard(10, "Clubs");

            usaCard1.ShowCard();
            usaCard2.ShowCard();
            usaCard3.ShowCard();

            myFuncs.WriteSeparatorLine("Compare the AmericanPlayingCard objects to see if equal");

            DisplayIfCardsAreEqual(usaCard1, usaCard2);
            DisplayIfCardsAreEqual(usaCard1, usaCard3);

            /*******************************************************************************
             * Italian PlayingCard Usage Examples
             ******************************************************************************/
            myFuncs.WriteSeparatorLine("Instantiate some ItalianPlayingCard objects and display them");

            ItalianPlayingCard italianCard1 = new ItalianPlayingCard(10, "Swords");
            ItalianPlayingCard italianCard2 = new ItalianPlayingCard(10, "Swords");
            ItalianPlayingCard italianCard3 = new ItalianPlayingCard(10, "Coins");

            italianCard1.ShowCard();
            italianCard2.ShowCard();
            italianCard3.ShowCard();

            myFuncs.WriteSeparatorLine("Compare the ItalianPlayingCard objects to see if equal");

            DisplayIfCardsAreEqual(italianCard1, italianCard2);
            DisplayIfCardsAreEqual(italianCard1, italianCard3);

            /*******************************************************************************
             * Swiss PlayingCard Usage Examples
             ******************************************************************************/
            myFuncs.WriteSeparatorLine("Instantiate some SwissPlayingCard objects and display them");

            SwissPlayingCard swissCard1 = new SwissPlayingCard(10, "Roses");
            SwissPlayingCard swissCard2 = new SwissPlayingCard(10, "Roses");
            SwissPlayingCard swissCard3 = new SwissPlayingCard(10, "Acorns");

            swissCard1.ShowCard();
            swissCard2.ShowCard();
            swissCard3.ShowCard();

            myFuncs.WriteSeparatorLine("Compare the SwissPlayingCard objects to see if equal");

            DisplayIfCardsAreEqual(swissCard1, swissCard2);
            DisplayIfCardsAreEqual(swissCard1, swissCard3);

            /*******************************************************************************
             * BlackJack PlayingCard Usage Examples
             ******************************************************************************/
            myFuncs.WriteSeparatorLine("Instantiate some BlackJackPlayingCard objects and display them");

            BlackJackCard blackJackCard1 = new BlackJackCard(1, "Diamonds");
            BlackJackCard blackJackCard2 = new BlackJackCard(1, "Diamonds");
            BlackJackCard blackJackCard3 = new BlackJackCard(1, "Hearts");
            BlackJackCard blackJackCard4 = new BlackJackCard(4, "Diamonds");


            blackJackCard1.ShowCard();
            blackJackCard2.ShowCard();
            blackJackCard3.ShowCard();
            blackJackCard4.ShowCard();

            myFuncs.WriteSeparatorLine("Compare the BlackJackCard objects to see if equal");

            DisplayIfCardsAreEqual(blackJackCard1, blackJackCard2);
            DisplayIfCardsAreEqual(blackJackCard1, blackJackCard3);
            DisplayIfCardsAreEqual(blackJackCard1, blackJackCard4);

            /*******************************************************************************
             * Using Polymorphism to create a Collection of different types of PlayingCards
             * and have them processed by the method defined in subclass when referenced
             ******************************************************************************/

            myFuncs.WriteSeparatorLine("Create a collection of various PlayingCard types and process them");

            // Create a collection of base class objects
            List<PlayingCard> someCards = new List<PlayingCard>();

            // Assigning sub-class objects into the base-class collection
            someCards.Add(blackJackCard1);
            someCards.Add(usaCard2);
            someCards.Add(swissCard3);
            someCards.Add(usaCard3);
            someCards.Add(italianCard1);
            someCards.Add(blackJackCard3);
            someCards.Add(usaCard1);
            someCards.Add(swissCard2);

            // When looping through the collection
            // Use a base-class object to run the methods
            foreach (PlayingCard aPlayingCard in someCards)
            {
                aPlayingCard.ShowCard(); // The class of object in aPlayingCard determines
            }                            //    which.ShowCard() method is run

            myFuncs.WriteSeparatorLine("Thanks for trying out The Polymorphism Example!");
            myFuncs.PauseProgram();

        }  // End of Main()

        // This method receives a base-class object
        //             and uses the base-class object to run the polymorphic methods
        // So whatever subclass object is passed to this method
        //             methods of the subclass will run rather than methods of teh base class
        static void DisplayIfCardsAreEqual(PlayingCard card1, PlayingCard card2)
        {
            myFuncs.WriteSeparatorLine("------ DisplayIfCardsAreEqual(PlayingCard card1, PlayingCard card2) method");
            Console.WriteLine($"Comparing a {card1.GetType()} to a {card2.GetType()}");
            Console.Write($"A {card1.CardColor} {card1.CardValue} of {card1.CardSuit} ");
            Console.Write($"{(card1.Equals(card2) ? "is EQUAL" : "is NOT equal")} to ");
            Console.WriteLine($"a {card2.CardColor} {card2.CardValue} of {card2.CardSuit} \n");
        }

        /**************************************************************************************************
         **************************************************************************************************
         **************************************************************************************************
         * The following code is included for training purposes only.
         *
         * It shows what would have been coded if Polymorphism was not used
         *
         * If you would like to run this code, simply remove the Block comment indicators
         *    surrounding it
         **************************************************************************************************
         **************************************************************************************************
         *************************************************************************************************/

        /***************************************************************************************
         * To compare the objects defined in the program without Polymorphism
         * We would have to code logic and/or overload methods to check each type of card
         *
         * i.e. Provide methods with the same names but different parameter types
         ***************************************************************************************/
        /* Start of non-Polymorphism example
         
        static void DisplayIfCardsAreEqual(AmericanPlayingCard card1, AmericanPlayingCard card2)
        {
            myFuncs.WriteSeparatorLine("------ DisplayIfCardsAreEqual(AmericanPlayingCard card1, AmericanPlayingCard card2) method");
            Console.WriteLine($"Comparing a {card1.GetType()} to a {card2.GetType()}");
            Console.Write($"A {card1.CardColor} {card2.CardValue} of {card1.CardSuit} ");
            Console.Write($"{(card1.Equals(card2) ? "is EQUAL" : "is NOT equal")} to ");
            Console.WriteLine($"a {card2.CardColor} {card2.CardValue} of {card2.CardSuit} \n");
        }
        static void DisplayIfCardsAreEqual(ItalianPlayingCard card1, ItalianPlayingCard card2)
        {
            myFuncs.WriteSeparatorLine("------ DisplayIfCardsAreEqual(ItalianPlayingCard card1, ItalianPlayingCard card2) method");
            Console.WriteLine($"Comparing a {card1.GetType()} to a {card2.GetType()}");
            Console.Write($"A {card1.CardColor} {card2.CardValue} of {card1.CardSuit} ");
            Console.Write($"{(card1.Equals(card2) ? "is EQUAL" : "is NOT equal")} to ");
            Console.WriteLine($"a {card2.CardColor} {card2.CardValue} of {card2.CardSuit} \n");
        }
        static void DisplayIfCardsAreEqual(SwissPlayingCard card1, SwissPlayingCard card2)
        {
            myFuncs.WriteSeparatorLine("------ DisplayIfCardsAreEqual(SwissPlayingCard card1, SwissPlayingCard card2) method");
            Console.WriteLine($"Comparing a {card1.GetType()} to a {card2.GetType()}");
            Console.Write($"A {card1.CardColor} {card2.CardValue} of {card1.CardSuit} ");
            Console.Write($"{(card1.Equals(card2) ? "is EQUAL" : "is NOT equal")} to ");
            Console.WriteLine($"a {card2.CardColor} {card2.CardValue} of {card2.CardSuit} \n");
        }
        static void DisplayIfCardsAreEqual(BlackJackCard card1, BlackJackCard card2)
        {
            myFuncs.WriteSeparatorLine("------ DisplayIfCardsAreEqual(BlackJackCard card1, BlackJackCard card2) method");
            Console.WriteLine($"Comparing a {card1.GetType()} to a {card2.GetType()}");
            Console.Write($"A {card1.CardColor} {card2.CardValue} of {card1.CardSuit} ");
            Console.Write($"{(card1.Equals(card2) ? "is EQUAL" : "is NOT equal")} to ");
            Console.WriteLine($"a {card2.CardColor} {card2.CardValue} of {card2.CardSuit} \n");
        }
        */ // End of non-polymorphic code

    }
}

