using System.Collections.Generic;
using System;

namespace Day_6_Interfaces
{
    public class RummyHand : ICardHand
    {
        /**********************************************************
         * Data Members
         *********************************************************/

        // Define a constant available to anyone for the of cards in the hand
        private const int INITIAL_NUMBER_CARDS_IN_HAND = 7;
        private const int MAX_NUMBER_CARDS_IN_HAND = 7;

        // Define a reference to and object to hold the cards in the hand
        // Note: USe of the base class type - Polymorphism is enabled if we need it
        private List<PlayingCard> theHand;

        /**********************************************************
         * Method Members
         *********************************************************/
        // Default constructor
        public RummyHand()
        {
            // Instantiate object data members and assign the object to the reference
            theHand = new List<PlayingCard>();
        }

        //---------------------------------------------------------------------------------
        // Methods required by the interface
        //---------------------------------------------------------------------------------

        // Draw a card(add a card to the hand)
        public void AddCard(PlayingCard cardToAdd)
        {
            // Only add a card to thee hand if it's not already full
            if (theHand.Count < MAX_NUMBER_CARDS_IN_HAND)
            {
                theHand.Add(cardToAdd);
            }
            else
            {
                Console.WriteLine("Hand is full - your card was not added");
            }
        }

        // Discard a card(remove a card from the hand)
        public void RemoveCard(PlayingCard cardToRemove)
        {
            theHand.Remove(cardToRemove);
        }

        // Show itself(display the value, color, suit of all cards in the hand)
        public void ShowHand()
        {
            foreach (PlayingCard card in theHand)
            {
                card.ShowCard();
            }
        }

        // Organize cards based on some criteria(values, suit, color, what makes you feel lucky)
        public void SortHand(string howToSort)
        {
            // To be done later due to time constraints - logic is fairly complex
        }

        // Throw the hand in (folding, clear the hand of cards)
        public void ThrowInHand()
        {
            theHand.Clear(); // Remove all the objects in the List
        }

        // Return a card from the hand based on it's position (1-1st position)
        public PlayingCard GetCardAtPosition(int position)
        {
            return theHand[position - 1]; // Adjust the position passed for 0-based index for List access
        }

        // Return initial number of cards to be dealt to a hand
        public int GetInitialCardsInHand()
        {
            return INITIAL_NUMBER_CARDS_IN_HAND;
        }

        // Return maximum number of cards allowed to be dealt to a hand
        public int GetMaxCardsInHand()
        {
            return MAX_NUMBER_CARDS_IN_HAND;
        }
    }
}