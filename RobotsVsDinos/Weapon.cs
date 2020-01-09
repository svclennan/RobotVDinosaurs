using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Weapon
    {
        public int damage;
        string name;

        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
    }
}
