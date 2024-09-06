
using System;
using System.Collections.Generic;

namespace Day_3_Inheritance
{
    // This is class to represent a simple PlayingCard
    // It's in the same namespace as the application (for now and for simplicity)
    //
    // access - public - any one can access and use
    //          private - only members of this class can access and use
    //
    // A class contains data and methods to operate and manipulate the data

//  access type  name
    public class PlayingCard
    {
        /*********************************************************************
         * Data members (attributes, properties, variables)
         *********************************************************************/

        // Define instance variables for the class (unique attributes for each object)
        //
        // Instance variables are private to implement Encapsulation
        //      (protect data from access outside the class)

        private int cardValue;
        private string cardSuit;
        private string cardColor;

        // To provide access so other can "see" or data members
        // We can provide "properties" to do that

        // A property is a public variable to allow access to private data
        //   using "getters" and "setters"
        //
        // A getter will return the value in a data member
        // A setter will allow the changing of data member
        //
        // A property is typically name the same as the variable in PascalCase

        // Define properties for access to data members
        public int CardValue // name is the data member in PascalCase
        {
            get { return cardValue; } // getter - return the value in cardValue
            set { cardValue = value; } // setter - set cardValue to value used when assigning
            //          value is keyword representing the value assigned        
        }

        public string CardSuit // name is the data member in PascalCase
        {
            get { return CardSuit; } // getter - return the value in cardSuit
            set // setter - set cardSuit to value used when assigning
            {
                cardSuit = value; // value is keyword representing the value assigned 
            }

        }

        public string CardColor // name is the data member in PascalCase
        {
            get { return cardColor; } // getter - return the value in cardValue

            // Note: No setter - we do not want the user to set the color

        }
        /*********************************************************************
         * Method members (functions that operate on the class data)
         *********************************************************************/

        // Every class has at least one constructor
        //
        // Constructors are responsible for initializing data in the object
        //
        // Constructors:   public, same name as class, no return type, may have parameters

        // Constructor to initialize all instance variables
        public PlayingCard(int theValue, string theSuit, string theColor)
        {
            cardValue = theValue; // initialize value to value passed 
            cardSuit = theSuit;   // initialize suit to suit passed  
            cardColor = theColor; // initialize the color to the color passed
        }

        // a Copy constructor to create a copy of a PlayingCard from a PlayingCard
        //   (aka "deep copy")
        // Avoids two references to same object when creating an object from an object
        //
        // A copy constructor receives and object of the class as a parameter
        // and initialize using the data members in that object

        public PlayingCard(PlayingCard sourceCard)
        {
            cardColor = sourceCard.cardColor;
            cardSuit = sourceCard.cardSuit;
            cardValue = sourceCard.cardValue;
        }

        /**************************************************************************
         * Class methods define the behavior of the class
         *************************************************************************/

        /**************************************************************************************
         * Method overrides to have class behave way we want not the default way
         *
         * System methods you should override:
         *
         *     public string ToString()         - Return a string representation of an object
         **************************************************************************************/

        /**************************************************************************************
         * Method overrides to have class behave way we want not the default way
         *
         * System methods you should override:
         *
         *     public string ToString()         - Return a string representation of an object
         *     public bool   Equals(object obj) - Determine if two objects are Equal
         *     public int    GetHashCode()      - Generate unique int value (HashCode) for object
         *                                        A HashCode is used by C# in certain cases
         *                                          to determine if two objects are equal
         **************************************************************************************/

        // Override the default ToString() method
        // We MUST be sure the method signature matches the method we are overriding
        // An override is substituting your processing for the default processing

        // Since the default ToString() returns a string and receives no parameters
        // The override must do the same

        // the override keyword, tells C# this is an override for a default behavior
        //                       C# will check to be sure your override signature
        //                                           matches the default

        // A method signature identifies the method and contains:
        //     
        //   1. Return type
        //   2. a method name
        //   3. parameter

        // ToString() returns an object of the class as a string
        public override string ToString()
        {
            return $"PlayingCard: Value={cardValue}, Color={cardColor}, Suit={cardSuit}";
        }

        // Equals returns true to data members of two objects are equal
        public override bool Equals(object otherObject)
        {
            if (otherObject.GetType() != this.GetType())  // If types differ...
            {
                return false;                             //     they can't be equal
            }

            if (otherObject == this)                      // if the same object...
            {
                return true;                              //    they must be equal
            }

            // Create a PlayingCard reference to generic object passed to method
            // so we can access the objects data members
            PlayingCard otherCard = (PlayingCard) otherObject;

            if (otherCard.cardValue == this.cardValue     // if all data
                && otherCard.cardSuit == this.cardSuit    //    members are equal
                && otherCard.cardColor == this.cardColor) //      between the objects...
            {
                return true;                              // they are equal   
            }
            return false;  // If not of the previous tests are true they must be unequal
        }


        // GetHashCode() should return a unique value generated by the member data
        public override int GetHashCode()
        {
            // A HashCode may be generated determining the sum of:
            //
            //     numeric values * prime-number
            //     string, bool, objects - Use System GetHashCode method
            return cardValue * 17 + cardColor.GetHashCode() + cardSuit.GetHashCode();
        }

    }  // End of PlayingCard class
} // End of namespace