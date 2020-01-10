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
        public string weaponType;
        public int heal;

        public Weapon()
        {
            bool validChoice = false;
            Console.WriteLine("What weapon would you like to use?\n1)Sword\n2)Gun\n3)Axe\n4)Bomb\n5)Healer");
            int weapon = Convert.ToInt32(Console.ReadLine());
            while (!validChoice)
            {
                switch (weapon)
                {
                    case 1:
                        {
                            this.damage = 3;
                            this.weaponType = "fight";
                            validChoice = true;
                            break;
                        }
                    case 2:
                        {
                            this.damage = 5;
                            this.weaponType = "fight";
                            validChoice = true;
                            break;
                        }
                    case 3:
                        {
                            this.damage = 4;
                            this.weaponType = "fight";
                            validChoice = true;
                            break;
                        }
                    case 4:
                        {
                            this.damage = 7;
                            this.weaponType = "fight";
                            validChoice = true;
                            break;
                        }
                    case 5:
                        {
                            this.heal = 6;
                            this.weaponType = "heal";
                            validChoice = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("That is not a valid weapon! Try again.");
                            weapon = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                }
            }
        }
        public Weapon(string name, int damage)
        {
            this.damage = damage;
        }
    }
}
