using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_5_Review
{
    // Array is used to hold a set of values all of the same type
    //       (instead of individual variables)
    // instead of using:
    //     double score1 = 4;
    //     double score2 = 5;
    //     double score3 = 6;
    //     double score4 = 7;
    //     double score5 = 8;
    //     double score6 = 9;

    //
    // we can code:
    //
    //     double[] testScores = { 4, 5, 6, 7, 8, 9 }
    //
    // datatype[] - indicates an array of the data type
    //
    // Access to an individual element is by index inside [] (0 = 1st element)
    //
    // Highest allowable index is length-of-array - 1
    //
    // If an index exceeds the highest allowable value an Exception is thrown
    //
    // typically a for loop is used to process an entire array:
    //
    //     for(int i=0; i < arrayName.Length; i++)
    //      {
    //          use arrayName[i] to access the current element
    //      }


internal class Program
    {
        static void Main(string[] args)
        {
            // Store a student's test scores in an array
            // Ask: datatype? double   How many test scores (max)? 6
//          double[] testScores = { 4, 5, 6, 7, 8, 9};

//
// alternate style when you don't know the initial values for the array
            double[] testScores = new double[6];

            //  Common mistake - using less-than-or-equal-to
//          for (int i = 0; i <= testScores.Length; i++)

           for (int i = 0; i < testScores.Length; i++)
                {
                testScores[i] = i * 10;
                }
            //
            //          assign values to each element somewhere in the code

            // To catch any exception that might occur in a teh code
            //  use try/catch block
            //
            //  try 
            //    {
            //      code that might throw an exception
            //      any code following an exception is skipped
            //    }
            //  catch (exception-process name-for-exception-block)
            //    {
            //     handle the exception:
            //          display a message
            //          display the data causing the error if available
            //          fix the error so process can continue
            //          throw another exception
            //          whatever you need to do to when an exception occurs
            //     }
            //  Code following the last catch block is executed after the catch
            //       block or if there was no exception

            // Catch an exception caused by the code that accesses the array
            try
            {
                Console.WriteLine($"Test score #3 is: {testScores[2]}");
                Console.WriteLine($"Test score #5 is: {testScores[4]}");
                Console.WriteLine($"Test score #1 is: {testScores[0]}");
                Console.WriteLine($"Test score #7 is: {testScores[6]}"); // Exception
                Console.WriteLine("This will not display if there is an Exception");
            }
            catch (IndexOutOfRangeException exceptionInfo) // if index out of range happens
            {
                // Notify the user
                Console.WriteLine("!!!! Index Range Error has occurred !!!!");
                // Display the message from the system for the exception
                Console.WriteLine(exceptionInfo.Message);
            }
            catch (Exception exceptionInfo)
            {
                // Notify the user
                Console.WriteLine("!!!! Error has occurred !!!!");
                // Display the message from the system for the exception
                Console.WriteLine(exceptionInfo.Message);
            }
            //****************************************************************************
            Console.WriteLine("\n ---- List example ----");
            //
            // A List is a set values all the same data type (like an array)
            // UNLIKE an array a List can be variable size
            //        it's size does not to known when you define it
            //        it can get bigger or smaller as you execute
            //
            // More flexible than an array
            //
            // TO define a List:
            //
            //    List<element-data-type> name = new List<element-data-type>();
            //
            //        NOTE: use of new keyword and same code on left of =
            //                     is used on right with ()
            //
            // To add an element to a List:  listName.Add(value-to-add);
            //
            // a foreach statement is typically used to process all elements in a list
            //
            // syntax:  foreach(element-type name-for-current-element in listName)
            //
            //          use the name-for-the-current-element in the processing of the loop
            //
            // Unlike a for-loop there is no index to tell you which element # is the current
            //  (YOU must keep track of the element number if you want it)
            //
            // a List element may be reference bu an index (just like an array)
            //  (a for-loop CAN be used to process a List)
            //
            // .Count = contains the number of elements in the List
            //          (not .Length)

            // Define a List to hold test scores
            List<double> listOfScores = new List<double>();

            // Add some test scores to the List
            listOfScores.Add(10);  // Store the value 10 in the 1st element
            listOfScores.Add(100); // Store the value 100 in the 2nd element
            listOfScores.Add(-10); // Store the value -10 in the 3rd element
            listOfScores.Add(90);  // Store the value 90  in the 4th element

            int currentElementNumber = 0;  // Hold the current element number

            // Display all elements in the List
            foreach (double currentScore in listOfScores)
            {
                Console.WriteLine($"Test Score {currentElementNumber}: {currentScore}");
                currentElementNumber++;  // increment element number each time through loop
            }

            Console.WriteLine($"Element #2 is: {listOfScores[1]}");

            // Display all elements in the List
            for (int i = 0; i < listOfScores.Count; i++)
            {
                Console.WriteLine($"Test Score {i}: {listOfScores[i]}");
            }

            Console.WriteLine("\n ---- Remove the second element from the List ----");
            Console.WriteLine("\n ---- Remove the value -10 from the List ----");
            listOfScores.RemoveAt(1);   // RemoveAt(index) removes the element at the index
            listOfScores.Remove(-10);   // Remove(value) removes the first element with that value

            // Display all elements in the List
            for (int i = 0; i < listOfScores.Count; i++)
            {
                Console.WriteLine($"Test Score {i}: {listOfScores[i]}");
            }

            //********************************************************************
            Console.WriteLine("\n ---- Dictionary example ----");

            // an array or a List can only store one value
            // so if you need to relate two values - Can't use an Array or a List
            //
            // For example:  We want to associate test scores with a student.
            //               We could use two arrays or two lists
            //               (like in student database problem)
            //
            // A dictionary is a better choice than two arrays to lists
            //
            // A dictionary is designed to relate two values in a data structure
            //
            //   a dictionary requires a Key and a Value
            //
            //   the Key is now you want to identify the value
            //   the value is what is associated with the Key
            //
            //   student-name = Key
            //   test-scores  = Value
            //
            //
            // Syntax: Dictionary<type-of-key, type-of-value> name = new Dictionary<type-of-key, type-of-value>
            //
            //

            // Define a Dictionary to hold 1 test score for each student
            // 
            //   Key   - name
            //   Value - test score
            //
            // To access a Dictionary entry by Key: 
            //
            //   dictionaryName[key-value]

            //          key     value
            //          type    type     name        
            Dictionary<string, double> studentScores = new Dictionary<string, double>();
           
            // Add some students and their test score
            studentScores.Add("Fonzie", 100);  // .Add(key-value, data-value);
            studentScores.Add("Richie", 90);   // .Add(key-value, data-value);
            studentScores.Add("Ralph", 50);    // .Add(key-value, data-value);
            studentScores.Add("Potsie", 74);   // .Add(key-value, data-value);

            // What did Fonzie get on the test
            Console.WriteLine($"Fonzie got a {studentScores["Fonzie"]}");
            //Console.WriteLine($"Fonzie got a {studentScores[0]}");         // index access is not allowed
            Console.WriteLine($"Fonzie got a {studentScores.ElementAt(0)}"); // index access is allowed
                                                                             //      via ElementAt(index)


            Console.WriteLine("Press enter");
            Console.ReadLine();

        }
    }
}
