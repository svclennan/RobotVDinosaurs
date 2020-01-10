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
            /*foreach (Dinosaur dino in army)
            {
                if (dino.health <= 0)
                {
                    army.Remove(dino);
                    break;
                }
            }*/
            Random random = new Random();
            for (int i = 0; i < army.Count; i++)
            {
                Console.WriteLine("Who would you like " + army[i].type + " to attack?");
                enemy.WriteLine();
                string target = Console.ReadLine();
                switch (target.ToUpper())
                {
                    case ("C-3PO"):
                        {
                            int index = enemy.getRobotIndex("C-3PO");
                            enemy.army[index].health -= army[i].attackPower;
                            if (enemy.army[index].health <= 0)
                            {
                                enemy.army.Remove(enemy.army[index]);
                                Console.WriteLine("C-3PO died!");
                            }
                            else
                            {
                                Console.WriteLine("C-3PO has " + enemy.army[index].health + " health left!");
                            }
                            Console.WriteLine();
                            break;
                        }
                    case ("R2-D2"):
                        {
                            int index = enemy.getRobotIndex("R2-D2");
                            enemy.army[index].health -= army[i].attackPower;
                            if (enemy.army[index].health <= 0)
                            {
                                enemy.army.Remove(enemy.army[index]);
                                Console.WriteLine("R2-D2 died!");
                            }
                            else
                            {
                                Console.WriteLine("R2-D2 has " + enemy.army[index].health + " health left!");
                            }
                            Console.WriteLine();
                            break;
                        }
                    case ("BB-8"):
                        {
                            int index = enemy.getRobotIndex("BB-8");
                            enemy.army[index].health -= army[i].attackPower;
                            if (enemy.army[index].health <= 0)
                            {
                                enemy.army.Remove(enemy.army[index]);
                                Console.WriteLine("BB-8 died!");
                            }
                            else
                            {
                                Console.WriteLine("BB-8 has " + enemy.army[index].health + " health left!");
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
            foreach (Dinosaur dino in army)
            {
                Console.WriteLine(dino.type + "(" + dino.health + ")");
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
