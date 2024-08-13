using System;


namespace Dice_Lab
{
    internal class Program
    {
        public static int GenerateRandomNumber(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue + 1);
        }
        static void Main(string[] args)
        {
        }
    }
}
