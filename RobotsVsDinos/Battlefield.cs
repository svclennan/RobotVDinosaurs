using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RobotsVsDinos
{
    class Battlefield
    {
        Herd blue;
        Fleet red;

        public Battlefield(Herd herd, Fleet fleet)
        {
            this.blue = herd;
            this.red = fleet;
        }

        public void Attack()
        {
            int round = 1;
            while(blue.army.Count > 0 && red.army.Count > 0)
            {
                Console.WriteLine("Round "+ round++);
                Thread.Sleep(150);
                Console.WriteLine(".");
                Thread.Sleep(150);
                Console.WriteLine(".");
                Thread.Sleep(150);
                Console.WriteLine(".");
                Thread.Sleep(150);
                Console.WriteLine("FIGHT!!!");
                Thread.Sleep(200);
                blue.Attack(red);
                red.Attack(blue);
            }
            if (red.army.Count == 0)
            {
                Console.WriteLine("Dinos Win!!!");
            }
            if (blue.army.Count == 0)
            {
                Console.WriteLine("Robots Win!!!");
            }
        }
    }
}
