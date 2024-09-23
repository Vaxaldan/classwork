namespace MockAssessment3
{
    /**************************************************************************************************
      class Slacker which will be a child of Villager

        Constructor: 
                 Set Hunger to 3

        Methods: 
                 Override Farm() return 0 
     ************************************************************************************************/

    public class Slacker : Villager
    {
        public Slacker() 
        {
            Hunger = 3;
        }
        public override int Farm()
        {
            return 0;
        }
    }
}
