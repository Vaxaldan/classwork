using System.Collections.Generic;
using System;

namespace Day_6_Abstract_Classes
{
    //               subclass   is-a superclass
    public class SwissPlayingCard : PlayingCard
    {
        // This is a subclass of a PlayingCard
        // and will add what an AmericanPlaying needs that differs from a PlayingCard:

        //     Card values: 0, 1, 6 to 13 (Joker to König, No 2 through 5)
        //     Card suits/colors:  Balls/Yellow, Acorns/Green, Roses/Red, Shields/Black
        //     Default card/color: Joker/Black


        // We get access to all the data and methods in the base class PlayingCard

        /*************************************************************************************
         * Additional data required by the subclass
         ************************************************************************************/
        private const int    DEFAULT_CARD_VALUE = 0;
        private const string DEFAULT_COLOR      = "Black";
        private const string DEFAULT_SUIT       = "Joker";
        private const int    MAX_CARD_VALUE     = 13;   // König
        private const int    MIN_CARD_VALUE     = 6;    

        private Dictionary<string, string> suitsColors = new Dictionary<string, string>();

        private string[] cardValueName =//   0       1         2         3           4          5        6       7    
                                        { "Joker", "As"  , "unknown", "unknown", "unknown", "unknown", "Six", "Seven",
                                          "Eight", "Nine", "Banner" , "Under"  , "Ober"   , "König"
                                        //   8        9       10        11         12         13
                                        };

        private List<int> invalidCardValues = new List<int>() {2,3,4,5};

        // Default Constructor for an SwissPlayingCard
        //     it must call the base() to initialize the base class

        public SwissPlayingCard() : base(DEFAULT_CARD_VALUE, DEFAULT_SUIT, DEFAULT_COLOR) { }

        // 3-arg Constructor for an SwissPlayingCard
        //       it must call the base() to initialize the base class
        //        with any values it gets when instantiated
        public SwissPlayingCard(int theValue, string theSuit)
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
            suitsColors.Add("Balls"  , "Yellow");
            suitsColors.Add("Acorns" , "Green");
            suitsColors.Add("Roses"  , "Red");
            suitsColors.Add("Shields", "Black");
            suitsColors.Add(DEFAULT_SUIT, DEFAULT_COLOR);
        }

        // Validate card value - if invalid, reset to default value
        // It is private so access is limited to members of this class
        private bool ValidateCardValue()
        {
            if ((base.CardValue < MIN_CARD_VALUE || base.CardValue > MAX_CARD_VALUE)
            || (invalidCardValues.Contains(base.CardValue)))
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
        // override keyword indicates this is replacing the method of the same name in the base class
        // we are overriding the base class method because we want different processing/behavior
        public override void ShowCard()
        {
            Console.WriteLine($"SwissPlayingCard: Value: {GetCardValueName()} ({base.CardValue}), Suit: {base.CardSuit}, Color: {base.CardColor}");
        }
    }
}