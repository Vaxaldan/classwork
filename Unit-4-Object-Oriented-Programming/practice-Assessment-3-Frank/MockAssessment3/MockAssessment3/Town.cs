namespace MockAssessment3
{
    /*******************************************************************************************************
      class Town 

        Properties:
            public List<Villager> Villagers 

        Constructor:
            Add 1 Farmer and 3 Slackers to the Villagers List 

        Methods: 
            public Harvest() - returns an int
                               Find the total of all the Villagers’ Farm() methods; 
                               return that total

           public CalcFoodConsumption() - returns an int
                                          Find the total of all the Villagers’ Hunger properties 
                                          Return that total

           public SurviveTheWinter() - returns a bool 
                                       Call and store the result of the Harvest() method 
                                       Call and store the result of the CalcFoodConsumption() method
                                       Return true if the value from CalcFoodConsumption 
                                                                     is less than or equal to Harvest.
                                       Return false if the value from CalcFoodConsumption 
                                                                     is greater than Harvest.
***********************************************************************************************************/

    public class Town
    {
        public List<Villager> Villagers = new List<Villager>();

        public Town()
        {
            Villagers.Add(new Farmer());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
            Villagers.Add(new Slacker());
        }

        public int Harvest()
        {
            int total = 0;

            foreach(Villager aVillager in Villagers)
            {
                total += aVillager.Farm();
            }
            return total;
        }
        public int CalcFoodConsumption()
        {
            int total = 0;

            foreach (Villager aVillager in Villagers)
            {
                total += aVillager.Hunger;
            }
            return total;
        }
        public bool SurviveTheWinter()
        {
            int harvestTotal = Harvest(); ;
            int foodConsumptionTotal = CalcFoodConsumption();

            return foodConsumptionTotal <= harvestTotal;
        }
    }
}
