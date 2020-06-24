using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    class Enemy : GameObject
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTOR
        public Enemy(string name) 
            : base(name)
        {
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
        public virtual float FireBullet()
        {
            Console.WriteLine("Firing Bullet!");
            return 20.0f;
        }
    }
}
