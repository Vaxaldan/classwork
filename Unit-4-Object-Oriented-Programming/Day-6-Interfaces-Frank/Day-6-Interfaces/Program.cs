using System;
using GeneralPurposeFunctions;

namespace Day_6_Interfaces
{
    internal class Program
    {
        private static CommonlyUsedFunctions generalFuncs = new CommonlyUsedFunctions();

        static void Main(string[] args)
        {
            generalFuncs.WriteSeparatorLine("Welcome to our Deck of Cards Example!");

            // Instantiate a CardDeck without Jokers to deal from and shuffle it
            CardDeck deckOfCards = new CardDeck();
            deckOfCards.Shuffle();

            /**************************************************************************
             * Interface usage examples (ICardHand objects)
             **************************************************************************/

            generalFuncs.WriteSeparatorLine("Instantiate a card hand, display its type, deal cards to it and display the hand");

            // Any class that implements the iCardHand interface can be processed by
            //     this program without change
            //
            // Activate (de-comment) only one of the following instantiation to demostrate

            PokerHand          theCardHand = new PokerHand();
            //ThreeCardPokerHand theCardHand = new ThreeCardPokerHand();
            //BlackJackHand      theCardHand = new BlackJackHand();
            //HeartsCardHand     theCardHand = new HeartsCardHand();
            //RummyHand theCardHand = new RummyHand();
            //BridgeCardHand     theCardHand = new BridgeCardHand();
            //GinRummyHand       theCardHand = new GinRummyHand();
            
            DisplayHandCharacterics(theCardHand);

            // Deal cards to the hand using the constant defined in the class for the initial number of cards
            for (int i = 1; i < theCardHand.GetInitialCardsInHand(); i++)
            {
                theCardHand.AddCard(deckOfCards.DealACard());
            }
            
            theCardHand.ShowHand();  // Display the cards in the hand

            generalFuncs.WriteSeparatorLine("Trying to add another card to hand...");
            // Try to add a extra card to the hand
            theCardHand.AddCard(new AmericanPlayingCard(13, "Spades"));


            // Try to add a extra card to the hand
            theCardHand.AddCard(new AmericanPlayingCard(13, "Spades"));

            generalFuncs.WriteSeparatorLine("Remove the 2nd card in the hand");
            // Throw the hand away
            theCardHand.RemoveCard(theCardHand.GetCardAtPosition(2)); // remove 2nd card in the List

            theCardHand.ShowHand();

            generalFuncs.WriteSeparatorLine("Add a card to hand");
            theCardHand.AddCard(deckOfCards.DealACard());
            theCardHand.ShowHand();

            generalFuncs.WriteSeparatorLine("Throwing in the Hand");
            // Throw the hand away
            theCardHand.ThrowInHand();

            theCardHand.ShowHand();  // Display the cards in the hand

            generalFuncs.PauseProgram();

            /**************************************************************************
             * Card deck examples
             **************************************************************************/

            deckOfCards.ShowDeck();
            deckOfCards.Count();

            generalFuncs.WriteSeparatorLine("Shuffling and displaying a deck of cards");
            deckOfCards.Shuffle();
            deckOfCards.ShowDeck();
            deckOfCards.Count();

            generalFuncs.WriteSeparatorLine("Instantiating and displaying a deck of cards WITH Jokers");
            CardDeck deckOfCards2 = new CardDeck(true);  // true tells the clas to add jokers to the deck
            deckOfCards2.ShowDeck();
            deckOfCards2.Count();

            generalFuncs.WriteSeparatorLine("Deal 5 cards from deck without Jokers");

            for (int i = 0; i < 5; i++)
            {
                PlayingCard card = deckOfCards.DealACard();

                if (card == null)  // if no cards in the deck
                {
                    Console.WriteLine("!!!! Uh-oh - No cards left in current deck, getting new one !!!!");
                    deckOfCards = new CardDeck();   // Create a new deck
                    deckOfCards.Shuffle();          // Shuffle it
                    card = deckOfCards.DealACard(); // Deal card from new deck
                } 
                card.ShowCard();
            }

            Console.WriteLine($"# cards left in Deck: {deckOfCards.Count()}");

            generalFuncs.WriteSeparatorLine("Thanks for visiting our Deck of Cards Example!");
            generalFuncs.PauseProgram();
        }

        /****************************************************************************************
         * Helper Methods for Main()
         ****************************************************************************************/
        // Display characteristics of the ICardHand object passed - Class, Initial size, Max size
        // Note use of interface name so method can process any class that implements iCardHand
        public static void DisplayHandCharacterics(ICardHand aHand)
        {
            // .GetType() returns: "namespaceName.ClassName"
            // We only want the Classname for we split the string version of the type at the '.'
            // and display the second part (what comes after the '.')

           string[] typeParts = aHand.GetType().ToString().Split('.');
           Console.WriteLine($"Hand is a {typeParts[1]} Hand with {aHand.GetInitialCardsInHand()} cards initially can hold up to {aHand.GetMaxCardsInHand()} cards\n");
        }
    }
}
