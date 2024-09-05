using System.Dynamic;

namespace Day_2_Playing_Card_Example
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

        private int    cardValue;
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
        public int CardValue  // name is the data member in Pascal
        {
            get { return cardValue; }   // getter - return the value in cardValue
            set { cardValue = value;}   // setter - set cardValue to value used when assigning
                                        //          value is keyword representing the value assigned        
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
            cardColor = theColor;  // initialize color to color passed 
            cardValue = theValue;  // initialize value to value passed 
            cardSuit  = theSuit;   // initialize suit to suit passed  
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
            cardSuit  = sourceCard.cardSuit;
            cardValue = sourceCard.cardValue;
        }


        /**************************************************************************
         * Method overrides to have class behave way we want not the default way
         *************************************************************************/

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
    }  // End of PlayingCard class
} // End of namespace