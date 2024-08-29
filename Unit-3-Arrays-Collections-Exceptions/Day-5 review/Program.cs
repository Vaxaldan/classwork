using System;
using System.Collections.Generic;



namespace Day_5_review
{
    // Arry is used to hold a set of values all of the same type
    //      (instead of individual variables)





    internal class Program
    {
        static void Main(string[] args)
        {
            // Store student's test score in an array
            // datatype?    how many test scores? (max) (6)

            double[] testScores = { 4, 5, 6, 7, 8, 9 };

            // altenate style for when you dont know the values of the array
            // double[] testScores = new double[6];
            //
            //      for(int i = 0; i < testScores.Length; i++)
            //      {
            //          testScores[i] = i * 10;
            //      }

            // whenever you see datatype[] - indicates an array of the datatype

            // Access to an individual element is by inside [] (0=element)
            // If an index exceeds the highest allowable value, an Exception is thrown

            // Typically a for loop is used to process an entire array:
            //           for(int i=0; i < arrayName.Length; i++)
            //              {
            //                  use arrayName[i] to access the current element
            //              }

            // To catch any exception that might occue in the code
            // use a try/catch block
            //
            // try
            //      {
            //          code that might throw an exception
            //          any code following an exception is skipped
            //      }
            // catch (exception-proess name-for0exception-block
            //      {
            //          Handle the exception:
            //          Discplay a message 
            //          Display the data causing the error if avaliable
            //          fix the error so process can continue
            //          throw another exception
            //          whatever you need to do when an exception occurs
            //      }

            // Code following the last catch block is executed after the catch block
            // or if there was no exception

            // Catch an exception caused by the code that accesses the array
            try
            {
                Console.WriteLine("Test score #3 is: " + testScores[2]);
                Console.WriteLine("Test score #5 is: " + testScores[4]);
                Console.WriteLine("Test score #1 is: " + testScores[0]);
                Console.WriteLine("Test score #7 is: " + testScores[6]); // Will cause an exception
                Console.WriteLine("This will not display if there is an Exception");
            }
            catch(IndexOutOfRangeException exceptionInfo)
            {
                Console.WriteLine($"{exceptionInfo.Message}");
            }  
            catch (Exception exceptionInfo)
            {
                Console.Write("!-!-!-!-ERROR-!-!-!-!");
                Console.WriteLine(exceptionInfo.Message);
            }


            //***************************************************************************************************************************
            Console.WriteLine("\n -----List Example-----");
            // A list is a set of values all the same data type (like an array)
            // UNLIKE an array, a List can be variable size
            //        it's size does not need to be known when you define it
            //        it can get larger or smaller as you execute it
            //        more flexible than an array
            //
            // To define a list:
            //    List<element-data-type> name = new List<element-data-type>();
            //     Note: use of new keyword and same code on left of =
            //           is used on the right with ( )
            //
            // To add an element to a List: listName.Add(value to add);
            //    foreach(element-type name-for-current-element in listName)
            //    use the name-for-current-element in processing of the loop
            //
            // Unlike a for-loop, there is no index to tell you what element number is current
            //        You must keep track of the element number if you want it
            // a List element may be referenced by an index
            //   a for-loop can be used to process a List, you just have to do it

            List<double> listScores = new List<double>();
            
            listScores.Add(10);
            listScores.Add(20);
            listScores.Add(30);
            listScores.Add(40);

            int currentElementNumber = 0; // sets element tracking

            // Display all elements in the List
            foreach (double currentScore in listScores)
            {
                Console.WriteLine("Test score: " + currentScore);
                currentElementNumber++; // increases to keep track of elements
            }

            Console.WriteLine("Element #2 is: " + listScores[1]);

            //**************************************************************************
            Console.WriteLine("\n ---- Dictionary Example ----");

            // an Arry or a List can only store one value
            // A Dicionary is a better choice than two arrays or lists
            //
            // A dictionary is designed to relate two values in a data structure
            //
            // A Dictionary requires a Key and a Value
            //
            // A Key is how you want to identify the Value
            // A Value is whats associated with the Key
            //
            //
            // student-name = Key
            // test-scores  = Value
            //
            // syntax: Dictionary<type-of-key, type-of-value> name = Dictionary<type-of-key, type-of-value>
            //
            //

            // Define a Dictionary to hold 1 test scores fpr each student
            //  Key   = name
            //  Value = score
            //
            // To access a Dictionary entry by Key:
            //    dictionaryName[key-value]
            
            Dictionary<string, double> studentScores = new Dictionary<string, double>();

            studentScores.Add("Fonzie", 100);
            studentScores.Add("Richie", 90);
            studentScores.Add("Ralph", 50);
            studentScores.Add("Potsie", 75);

            Console.WriteLine("Fonzie got a " + studentScores["Fonzie"]);

        }
    }
}
