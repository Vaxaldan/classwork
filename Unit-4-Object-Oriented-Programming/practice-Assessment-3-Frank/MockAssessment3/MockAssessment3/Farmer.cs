namespace MockAssessment3
{
    /*************************************************************************************************
      class Farmer which will be a child of Villager

       Constructor: 
              Set Hunger to 1

       Methods: 
              Override Farm() return 2
    **************************************************************************************************/
    public class Farmer : Villager
    {
        public Farmer() 
        {
            Hunger = 1;
        }

        public override int Farm()
        {
            return 2;
        }
    }
}
