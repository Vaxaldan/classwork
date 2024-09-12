using System;
using System.Collections.Generic;

namespace Day_6_Interfaces
{
    /**********************************************************************************************
     * This class represents a 52 card deck of AmericanPlayingCards with optional Jokers
     *********************************************************************************************/
    
    public class CardDeck
    {
        /******************************************************************************************
         * Data Members
         *****************************************************************************************/

        private List<AmericanPlayingCard> theDeck;


        /******************************************************************************************
         * Method Members
         *****************************************************************************************/

        //----------------------------------------------------------------------------------------
        // Constructors
        //----------------------------------------------------------------------------------------

        public CardDeck(bool jokerOption = false)
        {
            theDeck = new List<AmericanPlayingCard>();
            InitializeCardDeck(jokerOption);
        }

        //----------------------------------------------------------------------------------------
        // Helper methods - assist the class in it's processing objects of the class
        //----------------------------------------------------------------------------------------

        private void InitializeCardDeck(bool jokerOption)
        {
            AmericanPlayingCard aCard = new AmericanPlayingCard();
            for (int i = 1; i <= AmericanPlayingCard.MAX_CARD_VALUE; i++)
            {
                foreach (string aSuit in AmericanPlayingCard.GetSuits())
                {
                    if (aSuit == "Joker")
                    {
                        continue;
                    }
                   theDeck.Add(new AmericanPlayingCard(i, aSuit));
                }
            }
            if (jokerOption)
            {
                theDeck.Add(new AmericanPlayingCard(AmericanPlayingCard.DEFAULT_CARD_VALUE, AmericanPlayingCard.DEFAULT_SUIT));
                theDeck.Add(new AmericanPlayingCard(AmericanPlayingCard.DEFAULT_CARD_VALUE, AmericanPlayingCard.DEFAULT_SUIT));
            }

        }
        //----------------------------------------------------------------------------------------
        // Access methods - Allow users to access and manipulate objects of the class
        //----------------------------------------------------------------------------------------
        public void ShowDeck()
        {
            foreach(AmericanPlayingCard aCard in theDeck)
            {
                aCard.ShowCard();
            }
        }

        public AmericanPlayingCard DealACard()
        {
            if (theDeck.Count == 0)
            {
                return null;
            }

            AmericanPlayingCard cardDealt = theDeck[0];
            theDeck.RemoveAt(0);
            return cardDealt;
        }

        public int Count()
        {
            return theDeck.Count;
        }

        // Shuffle a card deck
        //  Loop through the deck. On each iteration, swap the current card with a randomly chosen one.
        public void Shuffle()
        {
            Random randomCardLocation = new Random();

            //  Loop through the deck from the end to the beginning
            //  On each iteration, swap the current card with a randomly chosen one.
            for (int currentCard = theDeck.Count - 1; currentCard > 0; --currentCard)
            {
                int swapCard = randomCardLocation.Next(currentCard + 1); // get random index for swap card
                AmericanPlayingCard heldCard = theDeck[currentCard];     // Remember the current card
                theDeck[currentCard]         = theDeck[swapCard];        // Replace current card with swap card
                theDeck[swapCard]            = heldCard;                 // Replace swap card with prior current card
            }
        }
    }
}