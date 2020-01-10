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
            /*foreach (Robot robo in army)
            {
                if (robo.health <= 0)
                {
                    army.Remove(robo);
                }
            }*/
            Random random = new Random();
            for (int i = 0; i < army.Count; i++)
            {
                Console.WriteLine("Who would you like " + army[i].name + " to attack?");
                enemy.WriteLine();
                string target = Console.ReadLine();
                switch (target.ToUpper())
                {
                    case ("T-REX"):
                        {
                            int index = enemy.getDinoIndex("T-REX");
                            enemy.army[index].health -= army[i].attackPower;
                            if (enemy.army[index].health <= 0)
                            {
                                enemy.army.Remove(enemy.army[index]);
                                Console.WriteLine("T-Rex died!");
                            }
                            else
                            {
                                Console.WriteLine("T-Rex has " + enemy.army[index].health + " health left!");
                            }
                            Console.WriteLine();
                            break;
                        }
                    case ("TRICERATOPS"):
                        {
                            int index = enemy.getDinoIndex("TRICERATOPS");
                            enemy.army[index].health -= army[i].attackPower;
                            if (enemy.army[index].health <= 0)
                            {
                                enemy.army.Remove(enemy.army[index]);
                                Console.WriteLine("Triceratops died!");
                            }
                            else
                            {
                                Console.WriteLine("Triceratops has " + enemy.army[index].health + " health left!");
                            }
                            Console.WriteLine();
                            break;
                        }
                    case ("RAPTOR"):
                        {
                            int index = enemy.getDinoIndex("RAPTOR");
                            enemy.army[index].health -= army[i].attackPower;
                            if (enemy.army[index].health <= 0)
                            {
                                enemy.army.Remove(enemy.army[index]);
                                Console.WriteLine("Raptor died!");
                            }
                            else
                            {
                                Console.WriteLine("Raptor has " + enemy.army[index].health + " health left!");
                            }
                            Console.WriteLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("That is not a valid option");
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
            foreach (Robot robo in army)
            {
                Console.WriteLine(robo.name + "(" + robo.health + ")");
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
