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
            
            //int redDamage = blue.Attack();
            //int blueDamage = red.Attack();
            //blue.Defend(redDamage);
            //red.Defend(blueDamage);
        }
    }
}
