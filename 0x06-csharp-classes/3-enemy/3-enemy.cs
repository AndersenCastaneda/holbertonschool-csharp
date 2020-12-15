using System;

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
    }
}
