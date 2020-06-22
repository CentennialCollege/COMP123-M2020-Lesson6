using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    class BossEnemy : Enemy
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTOR
        public BossEnemy() : 
            base("Boss")
        {
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
        public override void FireBullet()
        {
            Console.WriteLine("Firing FAT Bullet!");
        }
    }
}
