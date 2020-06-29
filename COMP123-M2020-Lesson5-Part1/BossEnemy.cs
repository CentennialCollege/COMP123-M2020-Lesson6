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
        public override float FireBullet()
        {
            Console.WriteLine($"{Name} Firing FAT Bullet!");
            return 40.0f;
        }

        // PUBLIC OVERRIDDEN METHODS (MAY override)
        public override void Start()
        {
            Console.WriteLine($"{GetType()} Start Method");
            Health = 200.0f;
        }


        public override void Update()
        {
            Console.WriteLine($"{GetType()} was Updated");
        }

        public override void Reset()
        {

        }
    }
}
