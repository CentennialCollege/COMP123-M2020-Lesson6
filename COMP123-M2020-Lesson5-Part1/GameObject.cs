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

        // CONSTRUCTOR(S) 
        public GameObject(string name)
        {
            Name = name;

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
            outputString += transform.ToString();

            return outputString;
        }
    }
}
