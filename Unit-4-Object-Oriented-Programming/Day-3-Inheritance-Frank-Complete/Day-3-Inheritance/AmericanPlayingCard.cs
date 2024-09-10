using System;
using System.Collections.Generic;
using Day_3_Inheritance;

namespace Day_3_Inheritance
{
    // This will be a subclass of a PlayingCard
    // and will add what an AmericanPlaying needs that differs from a PlayingCard:

    //     Card values: 0 to 13 (Joker to King)
    //     Card suits/colors: Spades/Black, Clubs/Black, Hearts/Red, Diamonds/Red
    //     Default card/color: Joker/Black

    //               subclass      is-a superclass
    public class AmericanPlayingCard : PlayingCard  // Indicate PlayingCard is our base class
    {
        // We get access to all the data and methods in the base class PlayingCard

        /*************************************************************************************
         * Additional data required by the subclass
         ************************************************************************************/
        private const int    DEFAULT_CARD_VALUE = 0;
        private const string DEFAULT_COLOR      = "Black";
        private const string DEFAULT_SUIT       = "Joker";
        private const int    MAX_CARD_VALUE     = 13;   // King
        private const int    MIN_CARD_VALUE     = 0;    // Joker

        private Dictionary<string, string> suitsColors = new Dictionary<string, string>();

        private string[] cardValueName =
                                        { "Joker", "Ace" , "Two", "Three", "Four" , "Five", "Six", "Seven",
                                          "Eight", "Nine", "Ten", "Jack" , "Queen", "King"
                                        };
        // Default Constructor for an AmericanPlayingCard
        //     it must call the base() to initialize the base class

        public AmericanPlayingCard() : base(DEFAULT_CARD_VALUE, DEFAULT_SUIT, DEFAULT_COLOR) {}

        // 3-arg Constructor for an AmericanPlayingCard
        //       it must call the base() method to initialize the base class
        //        with any values it gets when instantiated
        public AmericanPlayingCard(int theValue, string theSuit)
            : base(theValue, theSuit, DEFAULT_COLOR) // Pass all data to base class cto
        {                                            // Actual card color will be set after suit is validated
            InitializeSuitColors();

            if (!ValidateCardValue())
            {
                base.CardValue = DEFAULT_CARD_VALUE;
            };
            if (!ValidateCardSuit())
            {
                base.CardSuit = DEFAULT_SUIT;
            }

            base.CardColor = suitsColors[base.CardSuit];
        }

        /****************************************************************************************
         * Helper Methods for class - support class and manipulate data on behalf of the class
         ***************************************************************************************/

        // Initialize suitsColors Dictionary with valid suits and associated colors
        // It is private so access is limited to members of this class
        private void InitializeSuitColors()
        {
            suitsColors.Add("Spades"    , "Black");
            suitsColors.Add("Clubs"     , "Black");
            suitsColors.Add("Hearts"    , "Red");
            suitsColors.Add("Diamonds"  , "Red");
            suitsColors.Add(DEFAULT_SUIT, DEFAULT_COLOR);
        }

        // Validate card value - if invalid, reset to default value
        // It is private so access is limited to members of this class
        private bool ValidateCardValue()
        {
            if (base.CardValue < MIN_CARD_VALUE
                || base.CardValue > MAX_CARD_VALUE)
            {
                return false;
            }

            return true;
        }

        // Validate card suit - if invalid, reset to default suit
        // It is private so access is limited to members of this class
        private bool ValidateCardSuit()
        {
            if (!suitsColors.ContainsKey(base.CardSuit))
            {
                return false;
            }
            return true;
        }

        /****************************************************************************************
         * Overrides - Replace unwanted behavior of base class with behaviors for the subclass
         ***************************************************************************************/

        // No Overrides requires as base class processing does what we want it to do

        /****************************************************************************************
         * User Methods for class - Allow user to use and manipulate the class
         ***************************************************************************************/

        public string GetCardValueName()
        {
            return cardValueName[base.CardValue];
        }

        // Display an object of the class
        public void ShowCard()
        {
            Console.WriteLine($"AmericanPlayingCard: Value: {GetCardValueName()} ({base.CardValue}), Suit: {base.CardSuit}, Color: {base.CardColor}");
        }

    }
}