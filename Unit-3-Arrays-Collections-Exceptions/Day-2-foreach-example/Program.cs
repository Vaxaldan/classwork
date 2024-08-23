using System;

namespace Day_2_foreach_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define an array of doubles
            double[] doubleList = {2000, 1.5, 6.7, 13.3 };
            Console.WriteLine("\nDisplay all elements using for-loop");
            //display all elements in the array
            for (int i = 0; i < doubleList.Length; i++)
            {
                Console.WriteLine("Element # " + i + ": " + doubleList[i]);
            }

            //Display all the elements on the array using a foreach loop
            //
            //The foreach will go through the entire array from start to finish
            //            one element at a time assigning the current element
            //            to the variable specified
            //
            // syntax: for (datatype variable in array-name)
            //
            //              use the variable inside the loop to reference the current element
            // foreach has no way of knowing which element (index) that you are current element 
            Console.WriteLine("\nDisplay all elements using foreach-loop");
            foreach (double anElement in doubleList)
            {
                Console.WriteLine("Element: " + anElement);
            }

            // if you need to know the element number being processed in a foreach
            // YOU must keep track of it (foreach does not)
            // foreach cannot start anywhere but the first element
            //                nor stop before the last element

            Console.WriteLine("\nDisplay all elements using foreach-loop with index");
            int counter = 0;
            foreach (double anElement in doubleList)
            {
                Console.WriteLine("Element #: " + counter + ": " + anElement);
                counter++; //increment the element number

            }

            //display the second and third elements in the array
            // start the loop control variable at 1 (index of the second element)
            // make the condition stop at index 2 (i < 3)
            // Index 2 is the third element
            Console.WriteLine("\nDisplay elements 2 and 3");
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("Element # " + i + ": " + doubleList[i]);
            }
        }


    }
}
