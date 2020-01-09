using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Fleet
    {
        public List<Robot> army = new List<Robot>();
        public Fleet(Robot robot)
        {
            army.Add(robot);
        }

        public void addRobot(Robot robot)
        {
            army.Add(robot);
        }

        public void Attack(Herd enemy)
        {
            Random random = new Random();
            for (int i = 0; i < 3; i++)
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
                            Console.WriteLine();
                            Console.WriteLine("T-Rex has " + enemy.army[index].health + " health left!");
                            break;
                        }
                    case ("TRICERATOPS"):
                        {
                            int index = enemy.getDinoIndex("TRICERATOPS");
                            enemy.army[index].health -= army[i].attackPower;
                            Console.WriteLine();
                            Console.WriteLine("Triceratops has " + enemy.army[index].health + " health left!");
                            break;
                        }
                    case ("RAPTOR"):
                        {
                            int index = enemy.getDinoIndex("RAPTOR");
                            enemy.army[index].health -= army[i].attackPower;
                            Console.WriteLine("");
                            Console.WriteLine("Raptor has " +enemy.army[index].health + " health left!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("That is not a valid option");
                            break;
                        }
                }
            }
        }
        public void WriteLine()
        {
            foreach (Robot robo in army)
            {
                Console.WriteLine(robo.name);
            }
        }

        public int getRobotIndex(string name)
        {
            for(int i = 0; i < army.Count(); i++)
            {
                if(name == army[i].name)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
