using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_Card_Example
{

    // This is class to represent a simple playing card
    // It's in the same namespace as the application
    //
    // access - public  - anyone can access and use
    //        - private - only members of this class can access and use

    // access type name
    //
    // A class contains data abd nethods to operate and manipulate the data
    public class PlayingCard
    {
        /***************************************************************
        * Data members (attributes, properties, variables)
        * *************************************************************/

        // Define instance variables for the class (unique attributes for each class)
        private int cardValue;
        private string cardSuit;
        private string cardColor;

        // To provide access so others can "see" our data members
        // We can provide "properties" to do that
        // A property is a public variable to allow access to private data
        // using "getters" and "setters"
        // A getter will return the value in a data member
        // A setter will allow the changing of a data member
        // A property is typucally named the same as the variable in PascalCase

        // Define properties for access to data members
        public int CardValue
        {
            get { return cardValue; }  //getter - return the value in cardValue
            set { cardValue = value; } // setter - set cardValue to value used when assigning value is keyword
 
        }


        /***************************************************************
        * Method Members (functions that operate on the class data)
        * *************************************************************/

        // Every class has atleast one constructor
        //
        // Constructors are responsible for intializing data in the object
        //
        // Constructos - usually public, same name as the class, no return type, may have parameters


        // Constructor to initalize all the instance variables
        public PlayingCard(int theValue, string theSuit, string theColor)
        {
            cardColor = theColor; // Initialize color to color passed
            cardValue = theValue; // Initialize value to value passed
            cardSuit  = theSuit;  // Initialize suit to suit passed

        }

        public PlayingCard(PlayingCard sourceCard)
        {
            cardColor = sourceCard.cardColor;
            cardSuit = sourceCard.cardSuit;
            cardValue = sourceCard.cardValue;

        }

        //****************************************************************
        // Method overrides to have a Class behave the way we want
        //****************************************************************


        // Overrides the default ToString() method
        // We *must* be sure the method signature matches the method we are overriding
        // An override is subsituting your processing for the default processing

        // Since the default ToString() returns a string and recives no parameters
        // The override must do the same
        // The override keyword tells C# this is an override for a default behavior
        //                            C# will check to be sure your override signature
        //                                                     matches the default

        // ToString() returns an object of the class as a string
        public override string ToString()
        {
            return $"PlayingCard : Value = {cardValue}, Color = {cardColor}, Suit = {cardSuit}";
        }

    }
}
