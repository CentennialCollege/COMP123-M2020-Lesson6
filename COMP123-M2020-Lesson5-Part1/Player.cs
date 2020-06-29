using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson5_Part1
{
    class Player : GameObject
    {
        // PRIVATE INSTANCE VARIABLES
        private bool m_shieldsRaised;
        private float m_shieldLevel;

        // PUBLIC PROPERTIES
        public bool ShieldsRaised
        {
            get
            {
                return m_shieldsRaised;
            }

            set
            {
                m_shieldsRaised = value;
            }
        }

        public override float Health
        {
            get
            {
                return m_health;
            }

            set
            {
                if (ShieldsRaised)
                {
                    m_health = value + ShieldLevel;
                    Console.WriteLine($"Player's shields absorbed {ShieldLevel} damage");
                }
                else
                {
                    m_health = value;
                }
            }
        }

        public float ShieldLevel
        {
            get
            {
                return m_shieldLevel;
            }

            set
            {
                m_shieldLevel = value;
            }
        }

        // CONSTRUCTOR
        public Player() 
            : base(GameObjectType.PLAYER)
        {
            
        }

        // PRIVATE METHODS


        // PUBLIC METHODS
        public void RaiseShields()
        {
            Console.WriteLine("Raising Shields");
            ShieldsRaised = true;
        }

        public void LowerShields()
        {
            Console.WriteLine("Lowering Shields");
            ShieldsRaised = false;
        }

        // PUBLIC OVERRIDDEN METHODS
        public override void Start()
        {
            Console.WriteLine($"{GetType()} Start Method");
            m_shieldLevel = 10.0f;
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
