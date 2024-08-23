using System;

namespace Day_2_Multi_Dimensional_Arrays_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a 2-dimensional array is really just an array of arrays
            //
            // each row is an array of columns

            // Define a 2-dimenssional array (Rows and Columns)
            // 5 rows of 3 columns each
            // represents 5 bowlers with 3 scores each
            int[,] bowlers = new int[5, 3];

            // Loop through filling the array with the scores for each bowler
            //
            // arrayName.GetLength(dimension) - return the number of elements in the dimension
            //                      0 - 1st dimension
            //                      1 - 2nd dimension
            //
            //
            // Loop for the number of elements in the 1st dimension - GetLength(0)

            for (int i = 0; i < bowlers.GetLength(0); i++)
            {
                Console.WriteLine("Please enter the 3 scores for bowler # " + (i + 1)
                                                                            + " separated by \',\'");
                // .Split() will create a string array of values in a string seperated by the 
                //               delimiter/character specified

                // Seperate the values in the inout line based in the comma separator
                string[] bowlerScores = Console.ReadLine().Split(',');

                // Loop through the individual scores one at a time
                // and store them in the 2nd dimension of the 2-dimension array

                // Note the use of a nested-forloop - a for-loop inside a for-loop
                //
                // each inner for-loop runs for every loop of the outer for-loop
                //
                // i=0, j=0
                // i=0, j=1
                // i=0, j=2
                // i=1, j=0
                // i=1, j=1
                // i=1, j=2

                // Loop for the length of the 2nd dimenstion (GetLength(1)) if the array
                // in case the user gives more values whan will fit in the array

                for (int j = 0; j < bowlers.GetLength(1); j++)
                {
                    bowlers[i, j] = int.Parse(bowlerScores[j]);
                } // end of inner for-loop
            } // end of outer for-loop

            for (int i = 0; i < bowlers.GetLength(0); i++)
            {
                    Console.Write("\nBowler #" + (i+1) + " scores: ");

                    for (int j = 0; j < bowlers.GetLength(1); j++)
                    {
                        Console.Write(bowlers[i,j] + " ");
                    }

                    Console.Write("  Total Score: " + sumScores(bowlers, i));

                    Console.Write("  Average: " + sumScores(bowlers, i) / bowlers.GetLength(1));

            }

            Console.WriteLine("\n\nPress enter to end program...");
            Console.ReadLine();

        } // End of Main()

        static int sumScores(int[,] anArray, int bowlerNumber)
        {
            int sum = 0;

            for (int i = 0; i < anArray.GetLength(1); i++)
            {
                sum += anArray[bowlerNumber,i];
            }

            return sum;
        }
    } // End class Program
} // End namespace
