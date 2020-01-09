using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Herd
    {
        public List<Dinosaur> army = new List<Dinosaur>();
        public Herd(Dinosaur dinosaur)
        {
            army.Add(dinosaur);
        }

        public void addDinosaur(Dinosaur dinosaur)
        {
            army.Add(dinosaur);
        }

        public void Attack(Fleet enemy)
        {
            /*foreach (Dinosaur dino in army)
            {
                //Console.WriteLine("Who would you like " + dino.WriteLine() + " to attack?");
                //enemy.WriteLine();
                //string target = Console.ReadLine();
                //dino.Attack(target, enemy);
            }*/
            Random random = new Random();
            foreach (Robot robo in enemy.army)
            {
                for(int i = 0; i<3; i++)
                {
                    Console.WriteLine("Who would you like " + army[i].type + " to attack?");
                    enemy.WriteLine();
                    string target = Console.ReadLine();
                    if (target.ToUpper() == robo.name.ToUpper())
                    {
                        int missChance = random.Next(11);
                        if (army[i].energy != 0 && missChance != 1)
                        {
                            robo.health -= army[i].attackPower;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    Console.WriteLine(robo.health);
                }
            }
            /*for (int i = 0; i < 3; i++)
            {
                foreach (Robot robo in enemy.army)
                {
                    Console.WriteLine("Who would you like " + army[i].type + " to attack?");
                    enemy.WriteLine();
                    string target = Console.ReadLine();
                    if (target.ToUpper() == robo.name.ToUpper())
                    {
                        int missChance = random.Next(11);
                        if (army[i].energy != 0 && missChance != 1)
                        {
                            robo.health -= army[i].attackPower;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    Console.WriteLine(robo.health);
                }
            }*/


            /*foreach (Robot robo in enemy.army)
            {
                who would you like army[i] to attack
                 * string = answer
                 *if string.toupper == robo.name.toupper
                 *      attack
                 * else
                 *      i--
                 *
                 *
                int missChance = random.Next(11);
                if (army[i].energy != 0 && missChance != 1)
                {
                    robo.health -= army[i].attackPower;
                }
                i++;
                Console.WriteLine(robo.health);
            }*/
        }

        public void WriteLine()
        {
            foreach (Dinosaur dino in army)
            {
                Console.WriteLine(dino);
            }
        }
    }
}
