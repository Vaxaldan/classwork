
using System;
using System.Collections.Generic;

namespace Day_6_Abstract_Classes
{
    // This is class to represent a simple PlayingCard
    // It's in the same namespace as the application (for now and for simplicity)
    //

    public class PlayingCard
    {
    /*********************************************************************
     * Data members (attributes, properties, variables)
     *********************************************************************/
        
        //--------------------------------------------------------------
        // Instance variables
        //--------------------------------------------------------------
        private int    cardValue;
        private string cardSuit;
        private string cardColor;

        //---------------------------------------------------------------
        // Properties to allow controller access to instance variables
        //---------------------------------------------------------------
        public int CardValue // property name is the data member in PascalCase
        {
            get { return cardValue; }  // getter - return the value in cardValue
            set { cardValue = value; } // setter - set cardValue to value used when assigning
                                       //          value is keyword representing the value assigned        
        }

        public string CardSuit // property name is the data member in PascalCase
        {
            get { return cardSuit; } // getter - return the value in cardSuit
            set                      // setter - set cardSuit to value used when assigning
            {
                cardSuit = value; // value is keyword representing the value assigned 
            }

        }

        public string CardColor // property name is the data member in PascalCase
        {
            get { return cardColor; } // getter - return the value in cardValue

            set { cardColor = value; }// setter - value is keyword representing the value assigned 

        }

    /*********************************************************************
     * Method members (functions that operate on the class data)
     *********************************************************************/

        //---------------------------------------------------------------
        // Constructor to initialize all instance variables
        //---------------------------------------------------------------
        public PlayingCard(int theValue, string theSuit, string theColor)
        {
            cardValue = theValue; // initialize value to value passed 
            cardSuit  = theSuit;  // initialize suit to suit passed  
            cardColor = theColor; // initialize the color to the color passed
        }

        //---------------------------------------------------------------
        // a Copy constructor to create a copy of a PlayingCard from a PlayingCard
        //   (aka "deep copy")
        //---------------------------------------------------------------
        public PlayingCard(PlayingCard sourceCard)
        {
            cardColor = sourceCard.cardColor;
            cardSuit  = sourceCard.cardSuit;
            cardValue = sourceCard.cardValue;
        }

        /**************************************************************************
         * Class methods define the behavior of the class
         *************************************************************************/

        /*************************************************************************
         * Method overrides to have class behave way we want not the default way
         *************************************************************************/
        /*
        * An override is substituting your processing for the default processing of a method
        *
        * the override keyword, tells C# this is an override for a default behavior
        *                       C# will check to be sure your override signature
        *                                           matches the default
        *
        * System methods you should override:
        *
        *     public string ToString()         - Return a string representation of an object
        *     public bool   Equals(object obj) - Determine if two objects are Equal
        *     public int    GetHashCode()      - Generate unique int value (HashCode) for object
        *                                        A HashCode is used by C# in certain cases
        *                                          to determine if two objects are equal
        **************************************************************************************/

        //------------------------------------------------------------------
        // Override the default ToString() method: public string ToString() 
        //
        // ToString() returns an object of the class as a string
        //-----------------------------------------------------------------
        public override string ToString()
        {
            return $"PlayingCard: Value={cardValue}, Color={cardColor}, Suit={cardSuit}";
        }

        //---------------------------------------------------------------------
        // Override the default Equals() method: public bool Equals(object obj)
        // 
        // Equals() returns true to data members of two objects are equal
        //---------------------------------------------------------------------
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
            // so we can access the object's data members
            PlayingCard otherCard = (PlayingCard) otherObject;

            if (otherCard.cardValue == this.cardValue     // if all data
                && otherCard.cardSuit == this.cardSuit    //    members are equal
                && otherCard.cardColor == this.cardColor) //      between the objects...
            {
                return true;                              // they are equal   
            }
            return false;  // If none of the previous tests are true they must be unequal
        }
        //---------------------------------------------------------------------
        // Override the default GetHashCode method:  public int GetHashCode()
        //
        // GetHashCode() should return a unique value generated by the member data
        //
        // GetHashCode() is used by C# in certain situations to determine of two
        //                  objects are equal and when inserting an object in
        //                  a hash-based collection e.g. HashSet, HashTable. 
        //-------------------------------------------------------------------------
        public override int GetHashCode()
        {
            // A HashCode may be generated determining the sum of:
            //
            //     numeric values * prime-number
            //     string, bool, objects - Use System GetHashCode method
            return CardValue * 17 + CardColor.GetHashCode() + CardSuit.GetHashCode();
        }

        public virtual void ShowCard()
        {
            Console.WriteLine(this);
        }

    }  // End of PlayingCard class
} // End of namespace