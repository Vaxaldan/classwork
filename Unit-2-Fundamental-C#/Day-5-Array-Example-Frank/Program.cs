using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Array_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // An array is series of values of the same type stored together
            // All elements in an array are the same datatype
            // Once an array is created it's size cannot be changed
            // Elements are identified by an index (relative location in the series
            // Indexes start at 0 (first element is at index 0)
            // Highest valid index is the length of array - 1

            // To define an array:
            //
            //     datatype[] name = new datatype[#-of-elements] // elements are initialized to a default value
            //                                                   // numeric initialized to 0; strings empty bool false
            //     datatype[] name = {value1, value2, value3...] // size is determined by the number of value

            int[] charles = new int[5];   // Define an array of 5 ints

            int[] bradbury = { 2, 6, 78, 0, -3 }; // Define a 5 int element array

            // Set the values in the array using their index
            charles[0] = 10;
            charles[1] = 11;
            charles[2] = 12;
            charles[3] = 13;
            charles[4] = 14;

            // Typically a for-loop is used to process an array
            //
            //      for(int i=0; i < arrayName.Length; i++)  // Common for-loop to process an array
            //
            // use the for-loop variable (i) as the index to the array inside the loop

            // Display all element in the array charles
            for (int i = 0; i < charles.Length; i++)
            {
                Console.Write("["+i+"]  " + charles[i] + ", ");
            }

        }
    }
}
