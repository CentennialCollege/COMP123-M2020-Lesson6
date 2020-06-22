using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    class Transform
    {
        // PUBLIC INSTANCE VARIABLES
        public Vector2D position;
        public Vector2D rotation;
        public Vector2D scale;

        // CONSTRUCTOR
        public Transform()
        {
            m_initialize();
        }

        // PRIVATE METHODS
        private void m_initialize()
        {
            position = new Vector2D();
            rotation = new Vector2D();
            scale = new Vector2D();
        }

        /// <summary>
        /// This method formats the tranform to show each of it's components (position, rotation and scale)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";

            outputString += $"Position: " + position.ToString() + "\n";
            outputString += $"Rotation: " + rotation.ToString() + "\n";
            outputString += $"Scale   : " + scale.ToString() + "\n";

            return outputString;
        }
    }
}
