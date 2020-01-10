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
        public int healPower;

        public Robot()
        {
            Console.WriteLine("What is your robots name?");
            this.name = Console.ReadLine();
            Console.WriteLine("How much health does " + name + " have?");
            this.health = Convert.ToInt32(Console.ReadLine());
            this.weapon = new Weapon();
            if (this.weapon.weaponType == "fight")
            {
                this.attackPower = weapon.damage;
            }
            else
            {
                this.healPower = weapon.heal;
            }
        }
        public Robot(string name, string weaponName, int damage)
        {
            this.name = name;
            health = 20;
            powerLevel = 100;
            this.weapon = new Weapon(weaponName, damage);
            this.attackPower = weapon.damage;
        }
    }
}
