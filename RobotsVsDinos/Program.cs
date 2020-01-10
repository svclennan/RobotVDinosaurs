﻿using System;
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
            Robot c3po = new Robot("C-3PO", "fists", 2);
            Robot r2d2 = new Robot("R2-D2" , "lightning", 4);
            Robot bb8 = new Robot("BB-8", "bomb", 5);
            Fleet fleet = new Fleet(c3po);
            fleet.AddRobot(r2d2);
            fleet.AddRobot(bb8);

            Dinosaur tRex = new Dinosaur("T-Rex", 6);
            Dinosaur triceratops = new Dinosaur("Triceratops", 3);
            Dinosaur raptor = new Dinosaur("Raptor", 2);
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
