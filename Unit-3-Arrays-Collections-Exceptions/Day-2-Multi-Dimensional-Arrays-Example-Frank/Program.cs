using System;

namespace Day_2_Multi_Dimensional_Arrays_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a 2-dimensional array is really just and array of arrays
            //
            // each row is an array of columns

            // Define a 2-dimensional array (Rows and Columns)
            // 5 rows of 3 columns each
            // represents 5 bowlers with 3 scores each
            int[,] bowlers = new int[5, 3];

            // Loop through filling the array with the scores for each bowler
            //
            // arrayName.GetLength(dimension) - return the number of elements in the dimension
            //                        0 - 1st dimension
            //                        1 - 2nd dimension
            //
            //
            // Loop for the number of elements in the 1st dimension - GetLength(0)

            for (int bowlerNumber = 0; bowlerNumber < bowlers.GetLength(0); bowlerNumber++)
            {
                Console.WriteLine("Please enter the 3 scores for bowler # " + (bowlerNumber + 1)
                                                                            + " separated by \',\'");
                // .Split() will create a string array of values in a string separated by the
                //               delimiter/character specified
                
                // Separate the values in the input line based on teh comma separator
                string[] bowlerScores = Console.ReadLine().Split(',');
                
                // Loop through the individual scores one at a time
                // and store them in the 2nd dimension of the 2-dim array 

                // Note use of a nested-for-loop - a for-loop inside a for-loop
                // 
                // each inner for-loop runs for every loop the outer for-loop
                //
                // bowlerNumber=0, scoreNumber=0
                // bowlerNumber=0, scoreNumber=1
                // bowlerNumber=0, scoreNumber=2
                // bowlerNumber=1, scoreNumber=0
                // bowlerNumber=1, scoreNumber=1
                // bowlerNumber=1, scoreNumber=2
                // bowlerNumber=2, scoreNumber=0
                // bowlerNumber=2, scoreNumber=1
                // bowlerNumber=2, scoreNumber=2

                // Loop for the length of the 2nd dimension (GetLength(1)) of the array
                // In case the user gives use more values than wil fit in our array
                for (int scoreNumber = 0; scoreNumber < bowlers.GetLength(1); scoreNumber++)
                {
                    bowlers[bowlerNumber, scoreNumber] = int.Parse(bowlerScores[scoreNumber]);
                } // end of inner for-loop
            }  // End of outer for-loop

            // Nest for-loop to process the 2-dim array
            //
            // A rule of thumb: One for loop for each dimension

            // Loop for the length of 1st dimension
            for (int i = 0; i < bowlers.GetLength(0); i++)
            {
                    Console.Write("\nBowler #" + (i+1) + " scores: ");

                    // Loop for length of 2nd dimension
                    for (int j = 0; j < bowlers.GetLength(1); j++)
                    {
                        Console.Write(bowlers[i,j] + " ");
                    }

                    Console.Write("  Total Score: " + sumScores(bowlers, i));

                    Console.Write("  Average: " + sumScores(bowlers, i) / (double) bowlers.GetLength(1));

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
