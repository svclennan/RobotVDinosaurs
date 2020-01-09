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

        public void Attack(Herd herd)
        {
            int i = 0;
            Random random = new Random();
            foreach (Dinosaur dino in herd.army)
            {
                int missChance = random.Next(11);
                if (army[i].powerLevel != 0 && missChance != 1)
                {
                    dino.health -= army[i].attackPower;
                }
                i++;
                Console.WriteLine(dino.health);
            }
        }
        public void WriteLine()
        {
            foreach (Robot robo in army)
            {
                Console.WriteLine(robo.name);
            }
        }

        //public Robot getRobot()
        //{

        //}
    }
}
