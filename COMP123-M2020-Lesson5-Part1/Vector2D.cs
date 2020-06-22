using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    class Vector2D
    {
        // PUBLIC INSTANCE VARIABLES
        public float x;
        public float y;

        // CONSTRUCTOR

        /// <summary>
        /// This constructor takes x and y as optional parameters
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vector2D(float x = 0.0f, float y = 0.0f)
        {
            this.x = x;
            this.y = y;
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method returns the value of the x and y components with the format (x, y) as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = $"({x}, {y})";

            return outputString;
        }
    }
}
