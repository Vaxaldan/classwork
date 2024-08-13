using System;

/***************************************************************************************
 * This demonstrates various string methods available to process and manipulate strings
 *
 * a method is self-contained unit of code that can receive data and return data
 *
 * The are built-in methods which come with C#
 *
 *         programmer defined methods which you write to perform common tasks
 *
 *         class methods (later) to help a class fulfill its obligations
 *
 * To execute a method:    name.methodName(any-parameters)
 *                         parameters are data passed to the method
 *
 * A method may be executed anywhere a variable is allowed on right side of an assignment
 *****************************************************************************************/

namespace Unit_2_Day_4_Switch_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            string theLine = Console.ReadLine();

            // C# provides several escape characters to represent characters that can't be
            //    entered as text on the keyboard due to their having special meaning to the
            //    keyboard as you enter code.
            //
            //    an escape character starts with a '\'
            //
            //    '\n' - represents a new line you would get from the enter key
            //    '\t' - represents the tab character
            //    '\"' - represents a double quotes 
            //    '\'' - represents a single quotes
            //    '\\' - represents a back slash

            Console.WriteLine("\nYou entered: \"" + theLine + "\"");

            Console.WriteLine("\nThe line in all lowercase is: ");
            Console.WriteLine(theLine.ToLower()); // ToLower() method converts a string to lowercase

            Console.WriteLine("\nThe line in all uppercase is: ");
            Console.WriteLine(theLine.ToUpper()); // ToUpper convert a string to all uppercase

            Console.WriteLine("\nIt contains: \n");

            // .Length is a string property NOT a string method
            // 
            // a method name has ( after it
            //
            // a property is a piece of data C# automatically defines and keeps track of

            // Frank Rule of Thumb:  If you see a work followed by ( and the word isn't
            //                       if, while, switch then its a method name

            // .Length contains the number of characters in a string
            Console.WriteLine("\t" + theLine.Length + " characters");

            // Call the countChars() method to get the count of certain types of characters
            //
            // The countChars() method receives two pieces of data (inside the ()):
            //
            //     1. Type of character to count
            //     2. The string with the characters
            //
            //      in the countChars method:    typeToCount, sourceText
            Console.WriteLine("\t" + countChars("Consonants", theLine) + " consonant"         + (countChars("Consonants", theLine) > 1 ? "s" : ""));
            Console.WriteLine("\t" + countChars("Vowels"    , theLine) + " vowel"             + (countChars("Vowels", theLine)     > 1 ? "s" : ""));
            Console.WriteLine("\t" + countChars("Numbers"   , theLine) + " number"            + (countChars("Numbers", theLine)    > 1 ? "s" : ""));
            Console.WriteLine("\t" + countChars("Special"   , theLine) + " special character" + (countChars("Special", theLine)    > 1 ? "s" : ""));

            // .Split() will split a string into parts based on a character
            //
            //  The parts of the string are placed in an array of strings
            //
            //  an array a set of data identified by its relative position
            //
            //  to access an item in an array:  arrayName[location] the location is called an index

            string[] words = theLine.Split(' ');  // Split theLine based on a space
            Console.WriteLine("\t" + words.Length + " words");

            /***************************************************************************************
             *           theLine = "Welcome to C#!"
             *           string[] words = theLine.Split(' ');  // Split the string based on a space
             *
             *   (index) |   [0]   | [1] | [2] | (index starts 1t 0)
             *           |---------|-----|-----|
             *     words | Welcome | to  | C#! |
             *           |_________|_____|_____|
             *
             ***************************************************************************************/

            Console.WriteLine("\nThe first letter of each word is: ");

            // Loop through the array of words in the line one at a time using a for-loop

            for (int i = 0; i < words.Length; i++)  // i will go from 0, 1, 2  (words.length=3)
            {
                // .Substring() returns a portion of a string
                // .Substring(start-index, number-chars-you-want)
                // .Substring(0,1) - start at 1st character and give me 1 character
                Console.Write(words[i].Substring(0,1) + " "); // Note the use i as the index of the array
            }
            
            PauseProgram();

            Console.WriteLine("Enter a word to search for or enter to not search");
            string searchWord = Console.ReadLine();

            if (searchWord != "")
            {
                bool wordFound = theLine.Contains(searchWord);

                if (wordFound)
                {
                    Console.WriteLine("The word \"" + searchWord + "\" was found!");
                }
                else
                {
                    Console.WriteLine("The word \" " + searchWord + " was NOT found!");
                }
            }
            PauseProgram();  // call the method to cause the program to pause
         }  // End of Main() method

        // After the Main() method, programmer written methods may be code that the Main() method uses

        /******************************************************************************************
         * Helper methods used in Main() processing
         *
         * Note: Methods are static because Main() is static (more later)
         *****************************************************************************************/

        /******************************************************************************************
         * Method to Pause program and wait for enter
         *
         * Receives: no parameters
         *
         * Returns: nothing
         *****************************************************************************************/

        // method signature: static return-type name(parameters)
        //    
        //  parameters are data values shared with the method that method may use in it's processing
        //
        //  static - says there is only one of these for the whole application
        //           required because is static
        //
        //  void - return-type - void indicates the method method does not return a value 
        //
        //  PauseProgram - method-name
        //
        //  () - parameters shared with the method (none in this case)
        //
        static void PauseProgram()
        {
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        /******************************************************************************************
         * Method to count the various types of characters in a string
         *
         * Receives: Two parameters:  1. The type of character count to return called typeToCount
         *                            2. The string to be processed by the method called sourceText
         *                           
         * Returns: The count of the number of characters in the string of the type requested
         *****************************************************************************************/
//             return
//             type   name   (parameters) 
        static int countChars(string typeToCount, string sourceText)
        {
            string textToSearch  = sourceText.ToLower();  // Convert sourceText to lowercase

            // Count for various types of characters
            int vowelCount       = 0;  
            int consonantCount   = 0;
            int numberCount      = 0;
            int specialCharCount = 0;


            // Loop through the text we were given on character at a time
            // string can be treats as an array of chars where the first char is at index 0
            //                                             and the last char is at index string.length-1
            for (int i = 0; i < textToSearch.Length; i++)
            {
                // Use of switch to perform processing
                //
                // Note: Use of relational expression on case requires language level 9.0 or greater
                //
                // To use relational expression on case:
                //
                //     case variable-definition when condition-using-variable:
                //

                switch (textToSearch[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    {
                        vowelCount++;
                        break;
                    }
                    case char c when c >= 'a' && c <= 'z':
                    {
                        consonantCount++;
                        break;
                    }
                    case char aChar when aChar >= '0' && aChar <= '9':
                    {
                        numberCount++;
                        break;
                    }
                    default:
                    {
                        if (textToSearch[i] != ' ')
                        {
                            specialCharCount++;
                        }
                        break;
                    }
                }

                //if (textToSearch[i] == 'a'     // Use i to index through the string
                //    || textToSearch[i] == 'e'     // char literals are placed inside ' ' NOT " "
                //    || textToSearch[i] == 'i'
                //    || textToSearch[i] == 'o'
                //    || textToSearch[i] == 'u')
                //{
                //    vowelCount++;
                //}
                //else
                //{
                //    if (textToSearch[i] >= 'a' && sourceText[i] <= 'z')
                //    {
                //        consonantCount++;
                //    }
                //    else
                //    {
                //        if (textToSearch[i] >= '0' && sourceText[i] <= '9')
                //        {
                //            numberCount++;
                //        }
                //        else
                //        {
                //            if (textToSearch[i] != ' ')
                //            {
                //                specialCharCount++;
                //            }
                //        }
                //    }
                //}
            } // End of for-loop


            // return the count requested in the first parameter passed to use
            switch (typeToCount)
            {
                case "Vowels":
                {
                    return vowelCount;
                }
                case "Consonants":
                {
                    return consonantCount;
                }
                case "Numbers":
                {
                    return numberCount;
                }
                case "Special":
                {
                    return specialCharCount;
                }
                default:  // If a type we weren't expecting was requested...
                {
                    return -1;   // return an obviously incorrect value
                }
            }
            /********************************************************************************
             * Non-standard coding style
             
               switch (typeToCount)
               {
                   case "Vowels":     return vowelCount;
                   case "Consonants": return consonantCount;
                   case "Numbers":    return numberCount;
                   case "Special":    return specialCharCount;
                   default:           return -1;   // return an obviously incorrect value
                   }
               }

             ********************************************************************************/
        }

    }
}
