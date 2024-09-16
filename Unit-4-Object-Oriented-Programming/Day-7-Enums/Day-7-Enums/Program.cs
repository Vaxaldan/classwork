using System;
using GeneralPurposeFunctions;

namespace Day_7_Enums
{
    internal class Program
    {
        static CommonlyUsedFunctions myFuncs = new CommonlyUsedFunctions();

        static void Main(string[] args)
        {
            UsaPlayingCard card1 = new UsaPlayingCard(UsaPlayingCard.ValidCardValues.King
                                      ,UsaPlayingCard.ValidCardSuits.Spades);
            card1.ShowCard();

            UsaPlayingCard card2 = new UsaPlayingCard(UsaPlayingCard.ValidCardValues.Eight
                                     , UsaPlayingCard.ValidCardSuits.Diamonds);
            card2.ShowCard();

           Console.WriteLine($"\ncard 1 is {((card1 == card2) ? "equal to" : "not equal to")} card2)");

            myFuncs.PauseProgram();
            
        }
    }
}
