using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot c3po = new Robot("C-3PO", "fists", 4);
            Robot r2d2 = new Robot("R2-D2" , "lightning", 8);
            Robot robo3 = new Robot();
            Fleet fleet = new Fleet(c3po);
            fleet.AddRobot(r2d2);
            fleet.AddRobot(robo3);

            Dinosaur tRex = new Dinosaur("T-Rex", 25, 8);
            Dinosaur triceratops = new Dinosaur("Triceratops", 35, 3);
            Dinosaur raptor = new Dinosaur("Raptor", 10, 5);
            Herd herd = new Herd(tRex);
            herd.AddDinosaur(triceratops);
            herd.AddDinosaur(raptor);

            Battlefield arena = new Battlefield(herd, fleet);

            //herd.Attack(fleet);
            //Console.WriteLine();
            //fleet.Attack(herd);
            //Console.ReadLine();
            arena.Attack();
            Console.ReadLine();
        }
    }
}
