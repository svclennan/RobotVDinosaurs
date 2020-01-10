using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            while(blue.army.Count > 0 && red.army.Count > 0)
            {
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
