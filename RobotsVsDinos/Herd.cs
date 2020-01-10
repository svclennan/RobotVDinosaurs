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
            for (int i = 0; i < army.Count; i++)
            {
                if (enemy.army.Count == 0)
                {
                    break;
                }
                Console.WriteLine("Who would you like " + army[i].type + " to attack?");
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
            Thread.Sleep(1500);
            Console.Clear();
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

        public void TargetedAttack(Fleet enemy, int self, int target)
        {
            Random random = new Random();
            int missChance = random.Next(11);
            if (missChance != 1)
            {
                enemy.army[target - 1].health -= army[self].attackPower;
            }
            else
            {
                Console.WriteLine(army[self].type + "\'s attack missed.");
            }
            if (enemy.army[target-1].health <= 0)
            {
                Console.WriteLine(enemy.army[target-1].name + " died!");
                enemy.army.Remove(enemy.army[target-1]);
            }
            else
            {
                Console.WriteLine(enemy.army[target-1].name + " has " + enemy.army[target-1].health + " health left!");
            }
        }
    }
}
