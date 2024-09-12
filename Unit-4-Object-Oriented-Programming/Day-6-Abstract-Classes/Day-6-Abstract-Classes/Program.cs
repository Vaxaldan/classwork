using System;
using GeneralPurposeFunctions;

namespace Day_6_Abstract_Classes
{
    internal class Program
    {
        private static CommonlyUsedFunctions commonCode = new CommonlyUsedFunctions();

        static void Main(string[] args)
        {
            commonCode.WriteSeparatorLine("Welcome to the Abstract Class Example!");

     //     PlayingCard aCard = new PlayingCard(1, "Hearts", "Red");
            
            AmericanPlayingCard usaCard       = new AmericanPlayingCard(1, "Hearts");
            ItalianPlayingCard  italianCard   = new ItalianPlayingCard(10, "Cups");
            SwissPlayingCard    swissCard     = new SwissPlayingCard(13, "Shields");
            BlackJackCard       blackJackCard = new BlackJackCard(1, "Spades);");

            usaCard.ShowCard();
            blackJackCard.ShowCard();
            swissCard.ShowCard();
            italianCard.ShowCard();

            commonCode.WriteSeparatorLine("Thanks for using the Abstract Class Example!");
            commonCode.PauseProgram();

        }
    }
}
