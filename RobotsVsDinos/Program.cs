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
            Robot c3po = new Robot("C3-PO", "fists", 2);
            Robot r2d2 = new Robot("R2-D2" , "lightning", 4);
            Robot bb8 = new Robot("BB-8", "bomb", 5);
            Fleet fleet = new Fleet(c3po);
            fleet.addRobot(r2d2);
            fleet.addRobot(bb8);

            Dinosaur tRex = new Dinosaur("T-Rex", 6);
            Dinosaur triceratops = new Dinosaur("Triceratops", 3);
            Dinosaur raptor = new Dinosaur("Raptor", 2);
            Herd herd = new Herd(tRex);
            herd.addDinosaur(triceratops);
            herd.addDinosaur(raptor);

            Battlefield arena = new Battlefield(herd, fleet);

            herd.Attack(fleet);
            Console.WriteLine();
            fleet.Attack(herd);
            Console.ReadLine();
            //arena.Attack();
        }
    }
}
