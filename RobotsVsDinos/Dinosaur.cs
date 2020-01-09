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

        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            health = 20;
            energy = 100;
            this.attackPower = attackPower;
        }

        public void Attack(string target, Fleet fleet)
        {
            Random random = new Random();
            int missChance = random.Next(11);
            if ((energy != 0) && (missChance != 1))
            {
                /*foreach (Robot robo in fleet.army)
                {
                    if (robo == robo)
                    {

                    }
                }*/

            }
            else
            {

            }
        }
        public void Defend(int damage)
        {
            if (target.ToUpper() == type.ToUpper())
            {
                health -= damage;
                Console.WriteLine(type + " has " + health + " health left.");
            }
        }
        public string WriteLine()
        {
            return type;
        }
    }
}
