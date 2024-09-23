using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Group_Lab
{
    public abstract class Player
    {
        private string name;
        private Roshambo.RoshamboValues choice;

        public string Name {get { return name; } }

        public Player(string name, Roshambo.RoshamboValues choice)
        {
            this.name = name;
            this.choice = choice;
        }

        public Roshambo.RoshamboValues Choice 
        {
            get { return choice; }
            set { choice = value; }
        }

        public abstract Roshambo.RoshamboValues GenerateRoshambo();
    }
}
