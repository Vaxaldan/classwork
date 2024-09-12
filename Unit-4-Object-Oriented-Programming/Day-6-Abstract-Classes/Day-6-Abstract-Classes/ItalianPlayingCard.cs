using System.Collections.Generic;
using System;

namespace Day_6_Abstract_Classes
{
    //               subclass      is-a superclass
    public class ItalianPlayingCard : PlayingCard
    {
        // This is a subclass of a PlayingCard
        // and will add what an AmericanPlaying needs that differs from a PlayingCard:

        //     Card values: 0 to 13 (Joker to Re), No 8 or 9
        //     Card suits/colors: Coins/Yellow, Cups/Blue, Swords/Red, Batons/Black
        //     Default card/color: Joker/Black

        
        // We get access to all the data and methods in the base class PlayingCard
        
        /*************************************************************************************
         * Additional data required by the subclass
         ************************************************************************************/
            private const int    DEFAULT_CARD_VALUE = 0;
            private const string DEFAULT_COLOR      = "Black";
            private const string DEFAULT_SUIT       = "Joker";
            private const int    MAX_CARD_VALUE     = 13;   // Re
            private const int    MIN_CARD_VALUE     = 0;    // Joker

            private Dictionary<string, string> suitsColors = new Dictionary<string, string>();

            private string[] cardValueName =//   0         1          2       3        4          5       6       7
                                            { "Joker"  , "Ace"    , "Two", "Three" , "Four"   , "Five", "Six", "Seven",
                                              "unknown", "unknown", "Ten", "Fanta" , "Cavallo", "Re"
                                            //   8           9        10     11         12       13
                                        };
            // Since not all values between 0 and 13 are valid
            // This List wil be used to determin the invalid values
            private List<int> invalidCardValues = new List<int>() { 8, 9 };

            // Default Constructor for an ItalianPlayingCard
            //     it must call the base() to initialize the base class

            public ItalianPlayingCard() : base(DEFAULT_CARD_VALUE, DEFAULT_SUIT, DEFAULT_COLOR) { }    


        // 3-arg Constructor for an ItalianPlayingCard
        //       it must call the base() to initialize the base class
        //        with any values it gets when instantiated
        public ItalianPlayingCard(int theValue, string theSuit)
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
                suitsColors.Add("Coins" , "Yellow");
                suitsColors.Add("Cups"  , "Blue");
                suitsColors.Add("Swords", "Red");
                suitsColors.Add("Batons", "Black");
                suitsColors.Add(DEFAULT_SUIT, DEFAULT_COLOR);
            }

            // Validate card value - if invalid, reset to default value
            // It is private so access is limited to members of this class
            private bool ValidateCardValue()
            {
                if ((base.CardValue < MIN_CARD_VALUE || base.CardValue > MAX_CARD_VALUE)  // Outside valid range
                ||  (invalidCardValues.Contains(base.CardValue)))                         // or is invalid
                {
                    return false;                                                         //    say it's invalid
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
        // override keyword indicates this is replacing the method of the same name in the base class
        // we are overriding the base class method because we want different processing/behavior
        public override void ShowCard()
            {
                Console.WriteLine($"ItalianPlayingCard: Value: {GetCardValueName()} ({base.CardValue}), Suit: {base.CardSuit}, Color: {base.CardColor}");
            }
        }
}