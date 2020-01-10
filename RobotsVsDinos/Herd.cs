using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RobotsVsDinos
{
    class Herd
    {
        public List<Dinosaur> army = new List<Dinosaur>();
        public Herd(Dinosaur dinosaur)
        {
            army.Add(dinosaur);
        }

        public void AddDinosaur(Dinosaur dinosaur)
        {
            army.Add(dinosaur);
        }

        public void Attack(Fleet enemy)
        {
            Random random = new Random();
            for (int i = 0; i < army.Count; i++)
            {
                Console.WriteLine("Who would you like " + army[i].type + " to attack?");
                enemy.WriteLine();
                int target = Convert.ToInt32(Console.ReadLine());
                if (target > enemy.army.Count)
                {
                    Console.WriteLine("That target is already dead.");
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
                                Console.WriteLine(enemy.army[0].name + " died!");
                                enemy.army.Remove(enemy.army[0]);
                            }
                            else
                            {
                                Console.WriteLine(enemy.army[0].name + " has " + enemy.army[0].health + " health left!");
                            }
                            Console.WriteLine();
                            break;
                        }
                    case (2):
                        {
                            enemy.army[1].health -= army[i].attackPower;
                            if (enemy.army[1].health <= 0)
                            {
                                Console.WriteLine(enemy.army[1].name + " died!");
                                enemy.army.Remove(enemy.army[1]);
                            }
                            else
                            {
                                Console.WriteLine(enemy.army[1].name + " has " + enemy.army[1].health + " health left!");
                            }
                            Console.WriteLine();
                            break;
                        }
                    case (3):
                        {
                            enemy.army[2].health -= army[i].attackPower;
                            if (enemy.army[2].health <= 0)
                            {
                                Console.WriteLine(enemy.army[2].name + " died!");
                                enemy.army.Remove(enemy.army[2]);
                            }
                            else
                            {
                                Console.WriteLine(enemy.army[2].name + " has " + enemy.army[2].health + " health left!");
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

            //if (target.ToUpper() == robo.name.ToUpper())
            //{
            //    int missChance = random.Next(11);
            //    if (army[i].energy != 0 && missChance != 1)
            //    {
            //        robo.health -= army[i].attackPower;
            //    }
            //    else
            //    {
            //        i--;
            //    }
            //}
            //Console.WriteLine(robo.health);
            /*foreach (Robot robo in enemy.army)
            {
                for(int i = 0; i<3; i++)
                {
                    Console.WriteLine("Who would you like " + army[i].type + " to attack?");
                    enemy.WriteLine();
                    string target = Console.ReadLine();
                    switch (target.ToUpper())
                    {
                        case ("C-3PO"):
                            {
                                int index = enemy.getRobotIndex("C-3PO");
                                
                                break;
                            }
                    }
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

        public int GetHealth()
        {
            int total = 0;
            foreach (Dinosaur dino in army)
            {
                total += dino.health;
            }
            return total;
        }

        public void WriteLine()
        {
            int count = 1;
            foreach (Dinosaur dino in army)
            {
                Console.WriteLine(count + ")" + dino.type + "(" + dino.health + ")");
                count++;
            }
        }
        public int getDinoIndex(string name)
        {
            for (int i = 0; i < army.Count(); i++)
            {
                if (name.ToUpper() == army[i].type.ToUpper())
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
