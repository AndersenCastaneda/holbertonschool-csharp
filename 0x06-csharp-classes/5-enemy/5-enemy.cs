using System;

namespace Enemies
{
    public class Zombie
    {
        private int health;
        private string name = "(No name)";

        public Zombie()
        {
            this.health = 0;
        }

        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");

            this.health = value;
        }

        public int GetHealth() => health;

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

        public override string ToString() => $"Zombie name: {name} / Total Health: {health}";
    }
}
