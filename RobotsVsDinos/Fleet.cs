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
            Random random = new Random();
            for (int i = 0; i < army.Count; i++)
            {
                if (enemy.army.Count == 0)
                {
                    break;
                }
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
                switch (target)
                {
                    case (1):
                        {
                            enemy.army[0].health -= army[i].attackPower;
                            if (enemy.army[0].health <= 0)
                            {
                                Console.WriteLine(enemy.army[0].type + " died!");
                                enemy.army.Remove(enemy.army[0]);
                            }
                            else
                            {
                                Console.WriteLine(enemy.army[0].type + " has " + enemy.army[0].health + " health left!");
                            }
                            Console.WriteLine();
                            break;
                        }
                    case (2):
                        {
                            enemy.army[1].health -= army[i].attackPower;
                            if (enemy.army[1].health <= 0)
                            {
                               Console.WriteLine(enemy.army[1].type + " died!");
                               enemy.army.Remove(enemy.army[1]);
                            }
                            else
                            {
                                Console.WriteLine(enemy.army[1].type + " has " + enemy.army[1].health + " health left!");
                            }
                            Console.WriteLine();
                            break;
                       }
                    case (3):
                        {
                            enemy.army[2].health -= army[i].attackPower;
                            if (enemy.army[2].health <= 0)
                            {
                                Console.WriteLine(enemy.army[2].type + " died!");
                                enemy.army.Remove(enemy.army[2]);
                            }
                        else
                            {
                                Console.WriteLine(enemy.army[2].type + " has " + enemy.army[2].health + " health left!");
                            }
                            Console.WriteLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("That is not a valid option");
                            i--;
                            break;
                        }
                }
            }
            Thread.Sleep(1500);
            Console.Clear();
        }

        public int GetHealth()
        {
            int total = 0;
            foreach (Robot robo in army)
            {
                total += robo.health;
            }
            return total;
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

        public int getRobotIndex(string name)
        {
            for(int i = 0; i < army.Count(); i++)
            {
                if(name.ToUpper() == army[i].name.ToUpper())
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
