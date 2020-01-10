﻿using System;
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

        public Weapon()
        {
            //Add a Healer Bot
            bool validChoice = false;
            Console.WriteLine("What weapon would you like to use?\n1)Sword\n2)Gun\n3)Axe\n4)Bomb");
            int weapon = Convert.ToInt32(Console.ReadLine());
            while (!validChoice)
            {
                switch (weapon)
                {
                    case 1:
                        {
                            this.name = "Sword";
                            this.damage = 3;
                            validChoice = true;
                            break;
                        }
                    case 2:
                        {
                            this.name = "Gun";
                            this.damage = 6;
                            validChoice = true;
                            break;
                        }
                    case 3:
                        {
                            this.name = "Axe";
                            this.damage = 5;
                            validChoice = true;
                            break;
                        }
                    case 4:
                        {
                            this.name = "Bomb";
                            this.damage = 8;
                            validChoice = true;
                            break;
                        }
                    case 5:
                        {
                            this.name = "Healer";//Start of Healer
                            this.damage = 0;
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
            this.name = name;
            this.damage = damage;
        }
    }
}
