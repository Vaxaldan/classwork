namespace MockAssessment3
{
    internal class Program
    {
        /*******************************************************************************************
         * This code was not required by the assessment
         * 
         * It was done to test the classes
         *******************************************************************************************/

        static void Main(string[] args)
        {
            Town aTown = new Town();

            Console.WriteLine($"Harvest: {aTown.Harvest()} (expect 2)");
            Console.WriteLine($"Food Consumtion: {aTown.CalcFoodConsumption()} (expect 10)");
            Console.WriteLine($"Survive: {aTown.SurviveTheWinter()} (expect false)");

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
