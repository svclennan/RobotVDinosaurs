using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Robot
    {
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;
        public int attackPower;

        public Robot(string name, string weaponName, int damage)
        {
            this.name = name;
            health = 20;
            powerLevel = 100;
            this.weapon = new Weapon(weaponName, damage);
            this.attackPower = weapon.damage;
        }

        public int Attack()
        {
            Random random = new Random();
            int missChance = random.Next(11);
            if (powerLevel != 0 && missChance != 1)
            {
                return attackPower;
            }
            else
            {
                return 0;
            }
        }
        public void Defend(string target, int damage)
        {
            if (target.ToUpper() == name.ToUpper())
            {
                health -= damage;
                Console.WriteLine(name + " has " + health + " left.");
            }
        }
        public string WriteLine()
        {
            return name;
        }
    }
}
