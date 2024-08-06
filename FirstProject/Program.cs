// This is a single line comment

/*
 * This is a block comment - multiple lines
 */
// Any code in comments get ignored
//
// Program.cs is the main executable file for your application
// It contains the code for the applications

//using allows you access to c# code you need for the application

using System; // says Give me access to the basic C# system code (basic functionality)

// Code in C# is grouped in namespaces
//
// A namespace identifies a context in which a word or thing is defined or known
//             allows the same name or thing to be used in different contexts

// { } are used to indicate a self contained block of code (more later)
namespace FirstProject
{  // marks the start of the namespace First_Project
    // a Class is used to group things that are related or used together in an application
    // Evaery application has at leas one class containing the primary or start up code
    // an internal class cannot be used outside the contect in which defined (more later)
    internal class Program // Program is the name of the Class that contains the application
    {   // marks the start of the class called Program
        // Every application contains exactly one method called Main
        // a methis is a self contained unit of code
        // Main is the starting point for execution of the application
        //
        // static - indicates there is only one of these
        // void - indicates that a method does not return a value (more later)
        // Main - name of the method
        // (string[] args) - indicates the data type and name of any parameters for the method
        //                   (a lot more later)
       

        static void Main(string[] args)
        { //marks the start of the code in main


            // A piece of data in/for a program is called a variable
            // Not understanding the data in.for a program causes many programming issues (more later)
            //
            // variables have data types and names and may hold values compatible with the type
            //
            // Commonly used data types in C#:
            //
            // int - a whole number between +/- 2 billion
            // double - a number with decimal places
            // long - a whole number  +/- 2 billion
            // char - a single alphanumerical character
            // string - a multiple alphanumerical characters (words or sentences)
            // bool - true or false value
            //
            // define a variable holding the current year (2024)
           // to define a variable - datatype name = intial-value;
            
            int thisYear = 2024;

            //define a variable to hold the value of pi with 2-decimals
            double pi = 3.14;


            // to display a line on the screen - use Console.WriteLine("What to display");
            // Words or Characters are enclosed in " "
            // variable names or numeric values are not enclosed in " "
            //display the value in the variable thisYear
            Console.WriteLine("The year is: " + thisYear);

            // To keep the console window open after execution
            // Have the program wait for an enter key to be pressed to complete
            Console.WriteLine("Please press enter to continue...");
            Console.ReadLine(); //Read a line from the keyboard (Enter ends a line)
       
        
        } //marks the end of the code in main
    }  //marks the end of the class called Program
}   // marks the end of the namespace First_Project
