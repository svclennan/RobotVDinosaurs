using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Dinosaur
    {
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        public string target;

        public Dinosaur(string type, int health, int attackPower)
        {
            this.type = type;
            this.health = health;
            energy = 100;
            this.attackPower = attackPower;
        }
    }
}
