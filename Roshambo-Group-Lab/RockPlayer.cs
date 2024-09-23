using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Group_Lab
{
    public class RockPlayer : Player
    {
        public RockPlayer() : base("TheRock", Roshambo.RoshamboValues.Rock) { }

        public override Roshambo.RoshamboValues GenerateRoshambo()
        {
            return Roshambo.RoshamboValues.Rock;
        }
    }
}
