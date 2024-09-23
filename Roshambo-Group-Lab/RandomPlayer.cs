using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Group_Lab
{
    public class RandomPlayer : Player
    {
        public RandomPlayer(string name, Roshambo.RoshamboValues choice) : base(name, choice)
        {

        }

        public override Roshambo.RoshamboValues GenerateRoshambo()
        {
            Random randomNum = new Random();
            int randomChoice = randomNum.Next(0, 3);
            return (Roshambo.RoshamboValues)randomChoice;


        }
    }
}
