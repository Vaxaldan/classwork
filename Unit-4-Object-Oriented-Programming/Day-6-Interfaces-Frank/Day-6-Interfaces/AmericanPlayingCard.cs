using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_6_Interfaces
{
    // This is a subclass of a PlayingCard
    // and will add what an AmericanPlaying needs that differs from a PlayingCard:

    //     Card values: 0 to 13 (Joker to King)
    //     Card suits/colors: Spades/Black, Clubs/Black, Hearts/Red, Diamonds/Red
    //     Default card/color: Joker/Black

    //               subclass      is-a superclass
    public class AmericanPlayingCard : PlayingCard // Indicate PlayingCard is our base class
    {
        // We get access to all the data and methods in the base class PlayingCard

        /*************************************************************************************
         * Additional data required by the subclass
         ************************************************************************************/
        // Some of these constants have public access rather than private access
        // This allows them to be referenced with the ClassName. or the Object. notation
        // It's OK as far as Encapsulation is concerned because they cannot be changes (constants)
        public  const int    DEFAULT_CARD_VALUE = 0;
        private const string DEFAULT_COLOR      = "Black";
        public  const string DEFAULT_SUIT       = "Joker";
        public  const int    MAX_CARD_VALUE     = 13; // King
        public  const int    MIN_CARD_VALUE     = 0;  // Joker

        private static Dictionary<string, string> suitsColors = new Dictionary<string, string>()
        {
            {"Spades", "Black" },
            {"Clubs", "Black" },
            {"Hearts", "Red"},
            {"Diamonds", "Red"},
            {DEFAULT_SUIT, DEFAULT_COLOR}

        };

        private string[] cardValueName =//   0       1       2       3       4        5       6       7
                                        { "Joker", "Ace" , "Two", "Three", "Four" , "Five", "Six", "Seven",
                                          "Eight", "Nine", "Ten", "Jack" , "Queen", "King"
                                        //   8        9      10     11        12      13
                                        };

        // Default Constructor for an AmericanPlayingCard
        //     it must call the base() to initialize the base class

        public AmericanPlayingCard() : base(DEFAULT_CARD_VALUE, DEFAULT_SUIT, DEFAULT_COLOR) {}

        // 2-arg Constructor for an AmericanPlayingCard
        //       it must call the base() method to initialize the base class
        //        with any values it gets when instantiated
        //
        // Note: The super class (PlayingCard) only has a 3-arg ctor requiring a color
        //       We initialise the super class to default color since it's based on the suit
        //       We will change it once the processing in the constructor starts
        public AmericanPlayingCard(int theValue, string theSuit)
            : base(theValue, theSuit, DEFAULT_COLOR) // Pass all data to base class ctor
        {                                            // Actual card color will be set after suit is validated
            //InitializeSuitColors();

            // In the following code we are using the properties in the base class to set values
            // The base class owns it's data, so it's property know how to set its data
            //
            // Anything in the base class accessible to use can be accessed using base.

            if (!ValidateCardValue())                // If card value is invalid...
            {
                base.CardValue = DEFAULT_CARD_VALUE; //     set the card value to the default
            };
            if (!ValidateCardSuit())                 // if card suit is invalid...
            {
                base.CardSuit = DEFAULT_SUIT;        //     set the card suit to the default
            }

            base.CardColor = suitsColors[base.CardSuit]; // Set the card color based on the suit
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
            if (!suitsColors.ContainsKey(base.CardSuit)) // If the current suit is not in the Dictionary
            {
                return false;                            //     it's not a valid suit
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
        // Making the method static allows access using the className. or object. notation
        public static string[] GetSuits()
        {
            return suitsColors.Keys.ToArray();  // Convert the suits in the List to an array and return
        }

        public string GetCardValueName()
        {
            return cardValueName[base.CardValue];  // Use the card value as an an index to name array
        }

        // Display an object of the class
        // override keyword indicates this is replacing the method of the same name in the base class
        // we are overriding the base class method because we want different processing/behavior
        public override void ShowCard()
        {
            Console.WriteLine($"AmericanPlayingCard: Value: {GetCardValueName()} ({base.CardValue})\tSuit: {base.CardSuit}\tColor: {base.CardColor}");
        }
    }
}