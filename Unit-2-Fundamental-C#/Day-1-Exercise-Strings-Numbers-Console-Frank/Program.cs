using System;
/*******************************************************************************************
 * This class contains Frank's solutions to the Unit-2, Day 1 Exercise
 ******************************************************************************************/
/*******************************************************************************************
* Background information - Keyboard input:
*
*  1. Any data read from the keyboard using Console.ReadLine() will be a string
*
*  2. If you need to arithmetic with data entered from the keyboard you must
*     convert the string entered to the desired numeric data type.
*
*  3. Each numeric data type provides a method to convert a string to its type:
*
*          int.Parse(string)    - convert the string to an int
*          float.Parse(string)  - convert the string to a float
*          double.Parse(string) - convert the string to a double
*          long.Parse(string)   - convert the string to a long
*
*      If the string to be converted contains data that cannot be converted to the type,
*             a "System.Format.Exception" error occurs
*
*
*  4. The bool data type also contains a method to convert a string to a bool:
*
*         bool.Parse(string)
*
*     If the string to be converted contains data that cannot be converted to a bool (True or False),
*             a "System.Format.Exception" error occurs
*****************************************************************************************************/
/****************************************************************************************************
 * Background information - Data Types, conversion and casting
 *
 *
 * Computers can perform two types of arithmetic: integer and floating-point
 *
 * The type of arithmetic done depends on the data types of the values in the operation
 *
 *   if both are int-type values, integer arithmetic is done
 *   if both are floating-point types, floating-point arithmetic is done
 *   if they one is an int-type and the other a floating-point type,
 *               the int-type is converted to a floating-point type (double)
 *               and floating-point arithmetic is done.
 *
 *   int-types:  int, long, short, uint, ushort, ulong
 *
 *   floating-point types: float, double, decimal
 *
 *****************************************************************z*********************************/
/****************************************************************************************************
 * Background information - Casting
 *
 * Casting: Programmer controlled data conversion for teh duration of an expression
 *
 * A Programmer may initiate the temporary conversion of a value to a data type
 *              using a programming technique called casting.
 *
 * Casting will cause the conversion of a value to a specified type
 *              for th duration of an expression
 *
 * Syntax for casting:  (datatype) variable-or-value
 *
 * Casting is used when you have a variable defined as a type and you need to have it
 *  be treated a different type for the purposes of an operation or process
 *
 ******************************************************************************************/

namespace Day_1_Exercise_Strings_Numbers_Console_Frank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message followed by a blank line
            Console.WriteLine("Welcome to our exercise solution app!");
            Console.WriteLine();

            /************************************************************************************************
                EXERCISE 1.1: Echo String
            
                Prompt the user to enter a string. 
                After the user enters a string, output the same string back to the console.
            *************************************************************************************************/
            Console.WriteLine("Exercise #1.1 - Echo String");
            Console.WriteLine();

            // Prompt the user to enter a string
            Console.WriteLine("Hello, please enter some words or a sentence");

            // Get the string the user entered and store in a variable called aLine
            string aLine = Console.ReadLine();

            // Display the line entered by the user
            Console.WriteLine("Looks like you entered:");
            Console.WriteLine(aLine);

            /************************************************************************************************
               EXERCISE 1.2: Adding a number to an integer
                
               Prompt the user to enter a number. After the user enters a number, add 1 to the number and
               output it back to the console.
            ************************************************************************************************/
            Console.WriteLine("Exercise #1.2 - Adding a number to an integer");
            Console.WriteLine();

            // Prompt the user to enter a string
            Console.WriteLine("Hello, please enter a whole number (no decimal places)");

            // Get the string the user entered store it in a variable called dataEntered
            string dataEntered = Console.ReadLine();

            // Convert data entered by the user to an int so we can do arithmetic on it
            int aNum = int.Parse(dataEntered);

            // add 1 to the number entered by the user
            aNum = aNum + 1; // alternate code: aNum += 1;  or  aNum++;

            // Display what user entered an value after we added 1
            Console.WriteLine("You entered: " + dataEntered + " adding 1 to it makes it: " + aNum);

            /************************************************************************************************
               EXERCISE 1.3: Adding a number to a float
               
               Prompt the user to enter a number. After the user enters a number, add .5 to the number and
               output it back to the console.
            ************************************************************************************************/
            Console.WriteLine("Exercise #1.3 - Adding a number to an float");
            Console.WriteLine();

            // Prompt the user to enter a numeric value without decimal places
            Console.WriteLine("Hello, please enter a number with decimal places");

            // Get the string the user entered store it in a variable called valueEntered
            string valueEntered = Console.ReadLine();

            // Convert data entered by the user to an float so we can do arithmetic on it
            float aDecimalValue = float.Parse(valueEntered);

            // add .5 to the number entered by the user
            aDecimalValue = aDecimalValue + .5F; // alternate code: aDecimalValue += .5;

            // Display what user entered an value
            Console.WriteLine("You entered: " + valueEntered + " adding .5 to it makes it: " + aDecimalValue);

            /************************************************************************************************
              EXERCISE 1.4: Adding Two Floats
               
               Prompt the user to enter two numbers. After the user enters the numbers, add them together
               and output the sum back to the console.
            ************************************************************************************************/
            Console.WriteLine("Exercise #1.4 - Adding Two Floats");
            Console.WriteLine();

            // Prompt the user to enter a value with decimal places
            Console.WriteLine("Hello, please enter a number with decimal places");

            // Get the string the user entered and store it in whatUserEntered
            string whatUserEntered = Console.ReadLine();

            // Convert data entered by the user to an float so we can do arithmetic on it
            float value1 = float.Parse(whatUserEntered);


            // Prompt the user to enter a value with decimal places
            Console.WriteLine("Hello, please enter a number with decimal places");

            // Get the string the user entered and convert it to an float stored in whatUserEntered
            whatUserEntered = Console.ReadLine();  // Note reuse of variable defined earlier

            // Convert data entered by the user to a float so we can do arithmetic on it
            float value2 = float.Parse(whatUserEntered);

            // Add the two values together and store in variable called theSum
            float theSum = value1 + value2;

            // Display the values entered and their sum
            Console.WriteLine("You entered the values " + value1 + " and " + value2);
            Console.WriteLine("Their sum is: " + theSum);

            /***********************************************************************************
             * Alternate code:
             *
             * Do not define theSum variable to hold the result of the calculation
             *
             * Code the calculation in the Console.WriteLine instead of storing it in a variable:
             *
             *       Console.WriteLine("Their product is: " + value1 + value2);
             *
             ************************************************************************************/

            /************************************************************************************************
              EXERCISE 1.5: Multiplying Floats

               Prompt the user to enter two numbers. After the user enters the numbers, multiply them together
               and output the product back to the console.
            ************************************************************************************************/
            Console.WriteLine("Exercise #1.5 - Multiplying Floats");
            Console.WriteLine();

            // Prompt the user to enter a value with decimal places
            Console.WriteLine("Hello, please enter a number with decimal places");

            // Get the string the user entered and convert it to an float stored in whatUserEntered
            whatUserEntered = Console.ReadLine();  // Note reuse of variable defined earlier

            // Convert data entered by the user to an float so we can do arithmetic on it
            value1 = float.Parse(whatUserEntered); // Note reuse of variable defined earlier
            
            // Prompt the user to enter a value with decimal places
            Console.WriteLine("Hello, please enter a number with decimal places");

            // Get the string the user entered and store it in whatUserEntered
            whatUserEntered = Console.ReadLine();  // Note reuse of variable defined earlier

            // Convert data entered by the user to a float so we can do arithmetic on it
            value2 = float.Parse(whatUserEntered);

            // Multiply the two values together and store in variable called theProduct
            float theProduct = value1 * value2;  

            // Display the values entered and their product
            Console.WriteLine("You entered the values " + value1 + " and " + value2);
            Console.WriteLine("Their product is: " + theProduct);

            /***********************************************************************************
             * Alternate code:
             *
             *   1.Do not define theProduct variable to hold the result of the calculation
             *
             *   2.Code the calculation in the Console.WriteLine:
             *
             *       Console.WriteLine("Their product is: " + value1 * value2);
             *      
             ************************************************************************************/

            /************************************************************************************************
              EXERCISE 1.6: Dividing Integers

              Use the int type here. 

              Prompt the user to enter two numbers. 
              After the user enters the numbers, divide them and output the result back to the console. 
               
              Notice what happens when you enter two numbers that don’t divide evenly. 
              What number do you get? 
               
              Try running the program by entering decimal numbers. 
              What happens?
            ************************************************************************************************/
            Console.WriteLine("Exercise #1.6 - Dividing Integers");
            Console.WriteLine();

            // Prompt the user to enter a value with decimal places
            Console.WriteLine("Hello, please enter a number without decimal places");

            // Get the string the user entered and store it in whatUserEntered
            whatUserEntered = Console.ReadLine();  // Note reuse of variable defined earlier

            // Convert data entered by the user to a float so we can do arithmetic on it
            int intValue1 = int.Parse(whatUserEntered);

            // Prompt the user to enter a value with decimal places
            Console.WriteLine("Hello, please enter a number without decimal places");

            // Get the string the user entered and store it in whatUserEntered
            whatUserEntered = Console.ReadLine();  // Note reuse of variable defined earlier

            // Convert data entered by the user to a float so we can do arithmetic on it
            int intValue2 = int.Parse(whatUserEntered);


            // If 11 and 5 are entered, the result is 2 NOT 2.2
            Console.WriteLine(intValue1 + " divided by " + intValue2 + " is: " + intValue1 / intValue2);

            // If 11 and 5 are entered and either or bot are cast to a float or double, the result is 2.2
            Console.WriteLine(intValue1 + " divided by " + intValue2 + " is: " + (decimal) intValue1 / intValue2);

            /************************************************************************************************
              EXERCISE 1.7: Entering booleans
            
              Prompt the user to enter a boolean. Write out the boolean value, 
              and then write out the opposite of the boolean variable.

              Question: What possible things can the user enter to input a valid boolean? Try
              different things and see if you can come up with the answer.
               
              Next, notice also the difference between what you type into code for a boolean value
              of either true or false, and what displays on the screen when you WriteLine a boolean
              value.
            ************************************************************************************************/
            Console.WriteLine("Exercise #1.7 - Entering booleans");
            Console.WriteLine();
        
            // Prompt the user to enter a true or false value
            Console.WriteLine("Hello, please enter a true or false value");

            // Get the string the user entered and stored it in whatUserEntered
            whatUserEntered = Console.ReadLine(); // Note reuse of variable defined earlier

            // Convert data entered by the user to a bool value 
            bool boolVar = bool.Parse(whatUserEntered);

            // Display the value the user entered, and it's opposite
            Console.WriteLine("You entered: " + boolVar + " and it's opposite is: " + !boolVar);

            /************************************************************************************************
             End of Exercises
            ************************************************************************************************/

            // Have program wait for an enter key before closing the console window
            Console.WriteLine("Please press enter to continue..."); 
            Console.ReadLine();


            Console.WriteLine("Thanks for trying out our exercise solution app!");
}
}
}
