using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    // PRIVATE INSTANCE VARIABLES

    // PUBLIC PROPERTIES

    // CONSTRUCTOR
    class Player : GameObject
    {
        public Player() 
            : base("Player")
        {
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
        public void RaiseShields()
        {
            Console.WriteLine("Raising Shields");
        }
    }

}
