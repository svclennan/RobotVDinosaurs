using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RobotsVsDinos
{
    class Fleet
    {
        public List<Robot> army = new List<Robot>();
        public Fleet(Robot robot)
        {
            army.Add(robot);
        }

        public void AddRobot(Robot robot)
        {
            army.Add(robot);
        }

        public void Attack(Herd enemy)
        {
            for (int i = 0; i < army.Count; i++)
            {
                if (enemy.army.Count == 0)
                {
                    break;
                }
                if (army[i].weapon.weaponType == "heal")
                {
                    Console.WriteLine("Who would you like " + army[i].name + " to heal?");
                    WriteLine();
                    bool validTeammate = int.TryParse(Console.ReadLine(), out int teammate);
                    if (!validTeammate)
                    {
                        i--;
                        Console.WriteLine("Not a valid input.");
                        continue;
                    }
                    TargetedHeal(i, teammate);
                }
                else
                {
                    Console.WriteLine("Who would you like " + army[i].name + " to attack?");
                    enemy.WriteLine();
                    bool validInput = int.TryParse(Console.ReadLine(), out int target);
                    if (!validInput)
                    {
                        i--;
                        Console.WriteLine("Not a valid input.");
                        continue;
                    }
                    if (target > enemy.army.Count)
                    {
                        Console.WriteLine("You attacked air... Try again.");
                        i--;
                        continue;
                    }
                    TargetedAttack(enemy, i, target);
                    Console.WriteLine();
                }
            }
            Thread.Sleep(1500);
            Console.Clear();
        }

        public void WriteLine()
        {
            int count = 1;
            foreach (Robot robo in army)
            {
                Console.WriteLine(count + ")" + robo.name + "(" + robo.health + ")");
                count++;
            }
        }

        public void TargetedAttack(Herd enemy, int self, int target)
        {
            Random random = new Random();
            int missChance = random.Next(11);
            if (missChance != 1)
            {
                enemy.army[target - 1].health -= army[self].attackPower;
            }
            else
            {
                Console.WriteLine(army[self].name + "\'s attack missed.");
            }
            if (enemy.army[target - 1].health <= 0)
            {
                Console.WriteLine(enemy.army[target - 1].type + " died!");
                enemy.army.Remove(enemy.army[target - 1]);
            }
            else
            {
                Console.WriteLine(enemy.army[target - 1].type + " has " + enemy.army[target - 1].health + " health left!");
            }
        }

        public void TargetedHeal(int self, int target)
        {
            if (target <= army.Count)
            {
                army[target - 1].health += army[self].healPower;
                Console.WriteLine(army[target - 1].name + " now has " + army[target-1].health + " health");
            }
            else
            {
                Console.WriteLine("Not a valid target. Try again.");
                bool validChoice = int.TryParse(Console.ReadLine(), out target);
                while (!validChoice)
                {
                    Console.WriteLine("Enter a number.");
                    validChoice = int.TryParse(Console.ReadLine(), out target);
                }
                TargetedHeal(self, target);
            }
        }
    }
}
