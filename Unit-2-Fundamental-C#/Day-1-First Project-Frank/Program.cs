// This is single line comment
/*
 * This is a block comment - multiple lines
 */
// Any code in comment is ignored

// Program.cs is the main executable file for your application
// It contains the code the applications

// using allow you access to C# code you need for the application
using System;  // Give me access to the basic C# system code (basic functionality)

// Code in C# is grouped in namespaces
//
// A namespace identifies a context in which a word or thing is defined or known
//             allow the same name or thing to be used in different contexts
namespace First_Project
{  // marks the start of  the namespace First_Project
    // a Class is used to group things that related or used together in an application
    // Every application has at least on class containing the primary or start up code 
    // an internal class cannot be used outside the context in which defined (more later)

    // { } are used to indicate a self contained block of code

    internal class Program  // Program is the name of the Class that contains the application
    { // marks the start of the class called Program
        // Every application contains exactly one method called Main
        // A method is a self contained unit of code
        // Main is the starting point for execution of the application
        //
        // static - indicates there is only of these
        // void   - indicates a method does not return a value (more later)
        // Main   - the name of the method
        // (string[] args) - indicates the data type and name of any parameters for the method
        //                   (a lot more later)
       
        static void Main(string[] args)
        { // marks the start of code in main

            // A piece of data in/for a program is called a variable
            // Not understanding the data in/for a program causes many programming issues (more later)

            // variables have datatypes and names and may hold values compatible with the type

            // Commonly used datatypes in C#:
            //
            // int    - whole number between about +/- 2 billion
            // long   - a whole number greater than +/- 2 billion
            // double - a number with decimal places
            // char   - a single alphanumeric character
            // string - a multiple alphanumeric characters (words or sentences)
            // bool   - true or false value

            // to define a variable:  datatype name = initial-value;

            // define a variable holding the current year (2024)
            int thisYear = 2024;

            // define a variable to hold the value of pi with 2-decimals
            double pi = 3.14;

            // to display a line on the screen: Console.WriteLine("what to display");
            // Words or Characters are enclosed in ""
            // variable names or numeric values are not enclosed in ""
            //
            // Multiple things can be displayed by separating them with +

            // display the value in the variable thisYear
            Console.WriteLine("This year is: " + thisYear);

            // To keep the console window open after execution
            // Have the program wait for an enter key tp be pressed to complete
            Console.WriteLine("Please press enter to continue...");
            Console.ReadLine(); // Read a line from the keyboard (Enter ends a line)

        } // marks the end of code in main
    } // End of the class called Program
}  // marks the end of the namespace First_Project
