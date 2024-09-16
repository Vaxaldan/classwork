using System;
using System.Collections.Generic;

namespace Day_7_Enums
{
    // This is a subclass of a PlayingCard
    // and will add what an USA Playing needs that differs from a PlayingCard:

    //     Card values: 0 to 13 (Joker to King)
    //     Card suits/colors: Spades/Black, Clubs/Black, Hearts/Red, Diamonds/Red
    //     Default card/color: Joker/Black

    //               subclass      is-a superclass
    public class UsaPlayingCard : PlayingCard // Indicate PlayingCard is our base class
    {
        // We get access to all the data and methods in the base class PlayingCard

        /*************************************************************************************
         * Enumerated Types for class
         *
         * Assign words to represent value to assist coding and data validation
         ************************************************************************************/

        public enum ValidCardSuits
        {
            Joker,     // 0
            Clubs,     // 1
            Diamonds,  // 2
            Hearts,    // 3
            Spades     // 4
        };

        public enum ValidCardValues
        {
            Joker,  // 0
            One,    // 1
            Two,    // 2
            Three,  // 3
            Four,   // 4
            Five,   // 5
            Six,    // 6
            Seven,  // 7
            Eight,  // 8
            Nine,   // 9
            Ten,    // 10
            Jack,   // 11
            Queen,  // 12
            King    // 13
        };

        public enum ValidCardColors
        {
            Black,
            Red
        };
        
        /*************************************************************************************
         * Additional data required by the subclass
         ************************************************************************************/
        // Some of these constants have public access rather than private access
        // This allows them to be referenced with the ClassName. or the Object. notation
        // It's OK as far as Encapsulation is concerned because they cannot be changes (constants)
        public const ValidCardValues DEFAULT_CARD_VALUE = ValidCardValues.Joker;
        public const ValidCardColors DEFAULT_COLOR      = ValidCardColors.Black;
        public const ValidCardSuits  DEFAULT_SUIT       = ValidCardSuits.Joker;
        public const ValidCardValues MAX_CARD_VALUE     = ValidCardValues.King;
        public const ValidCardValues MIN_CARD_VALUE     = ValidCardValues.Joker;

        private static Dictionary<ValidCardSuits, ValidCardColors> suitsColors = new Dictionary<ValidCardSuits, ValidCardColors>()
        {
            { ValidCardSuits.Spades  , ValidCardColors.Black},
            { ValidCardSuits.Clubs   , ValidCardColors.Black},
            { ValidCardSuits.Hearts  , ValidCardColors.Red},
            { ValidCardSuits.Diamonds, ValidCardColors.Red},
            {DEFAULT_SUIT            , DEFAULT_COLOR}

        };


        // Default Constructor for an UsaPlayingCard
        //     it must call the base() to initialize the base class

        public UsaPlayingCard() : base((int) DEFAULT_CARD_VALUE, DEFAULT_SUIT.ToString(), DEFAULT_COLOR.ToString()) {}

        // 2-arg Constructor for an UsaPlayingCard
        //       it must call the base() method to initialize the base class
        //        with any values it gets when instantiated
        //
        // Note: The super class (PlayingCard) only has a 3-arg ctor requiring a color
        //       We initialise the super class to default color since it's based on the suit
        //       We will change it once the processing in the constructor starts
        public UsaPlayingCard(ValidCardValues theValue, ValidCardSuits theSuit)
            : base((int) theValue, theSuit.ToString(), DEFAULT_COLOR.ToString()) // Pass all data to base class ctor
        {                                                                        // Actual card color will be set after suit is validated
          // No validation of theValue and theSuit is necessary due to enum usage

          // Set the card color based on the suit

          switch (theSuit)
          {
                case ValidCardSuits.Spades:
                case ValidCardSuits.Clubs:
                {
                    base.CardColor = ValidCardColors.Black.ToString(); 
                    break;
                }
                case ValidCardSuits.Hearts:
                case ValidCardSuits.Diamonds:
                {
                    base.CardColor = ValidCardColors.Red.ToString();
                    break;
                }
                default:
                {
                    base.CardColor = DEFAULT_COLOR.ToString();
                    break;
                }
            }
        }

        /****************************************************************************************
         * Helper Methods for class - support class and manipulate data on behalf of the class
         ***************************************************************************************/

        // Validation helper methods removed due enum use

        /****************************************************************************************
         * Overrides - Replace unwanted behavior of base class with behaviors for the subclass
         ***************************************************************************************/

        // No Overrides requires as base class processing does what we want it to do

        /****************************************************************************************
         * User Methods for class - Allow user to use and manipulate the class
         ***************************************************************************************/

        // Display an object of the class
        // override keyword indicates this is replacing the method of the same name in the base class
        // we are overriding the base class method because we want different processing/behavior
        public override void ShowCard()
        {
            Console.WriteLine($"UsaPlayingCard: Value: {(ValidCardValues) base.CardValue} ({base.CardValue})\tSuit: {base.CardSuit}\tColor: {base.CardColor}");
        }
    }
}