using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    class GameObject
    {
        // PRIVATE INSTANCE MEMBERS (FIELDS)
        private string m_name;
        protected float m_health;

        // PUBLIC PROPERTIES
        public Transform transform { get; set; }

        public string Name
        {
            get
            {
                return m_name;
            }

            set
            { 
                m_name = value;
            }
        }

        public virtual float Health
        {
            get
            {
                return m_health;
            }

            set
            {
                m_health = value;
            }
        }

        // CONSTRUCTOR(S) 

        /// <summary>
        /// This Constructor requires a name for the GameObject with an optional health value.
        /// By Default all GameObjects have a health value of 100.0
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        public GameObject(string name, float health = 100.0f)
        {
            Name = name;
            Health = health;

            m_initialize();
        }

        // PRIVATE METHODS
        private void m_initialize()
        {
            transform = new Transform();
        }

        // PUBLIC METHOD
        public override string ToString()
        {
            string outputString = "";

            outputString += $"Name    : {Name}\n";
            outputString += $"Health  : {Health}\n";
            outputString += transform.ToString();

            return outputString;
        }
    }
}
