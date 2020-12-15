﻿using System;

namespace Enemies
{
    /// <summary>
    /// Class Zombie
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Zombie's health
        /// </summary>
        private int health;

        /// <summary>
        /// Zombie's name
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// Creates a new Zombie and sets health to 0
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Creates a new Zombie and sets health to value
        /// </summary>
        /// <param name="value">Value must be >= 0</param>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");

            this.health = value;
        }

        /// <summary>
        /// Gets zombies health
        /// </summary>
        /// <returns>Zombie's health</returns>
        public int GetHealth() => health;

        /// <summary>
        /// Property Name
        /// </summary>
        /// <value>Sets and Gets zombie's name</value>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// String representation of Zombie object
        /// </summary>
        /// <returns>Returns Zombie name: Zombie's name/ Total helath: Zombies'health</returns>
        public override string ToString() => $"Zombie Name: {name} / Total Health: {health}";
    }
}
