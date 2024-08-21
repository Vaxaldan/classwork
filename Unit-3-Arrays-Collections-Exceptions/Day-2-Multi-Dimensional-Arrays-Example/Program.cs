using System;

namespace Day_2_Multi_Dimensional_Arrays_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] bowlers = new int[5, 3];

            for (int i = 0; i < bowlers.GetLength(0); i++)
            {
                Console.WriteLine("Please enter the 3 scores for bowler # " + (i + 1)
                                                                            + " separated by \',\'");
                string[] bowlerScores = Console.ReadLine().Split(',');

                for (int j = 0; j < bowlers.GetLength(1); j++)
                {
                    bowlers[i, j] = int.Parse(bowlerScores[j]);
                }
            }

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
