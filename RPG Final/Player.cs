using System;

namespace RPG
{
    public class Player : IHealAttack
    {
        public int dmg = 15;
        public int health = 75;

        public string weapon = "club";

        string name
        {
            get;
            set;
        }

        public void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        public void Heal(int healthadd)
        {
            this.health += healthadd;
        }

        public void IncreaseDamage(int damage)
        {
            this.dmg += damage;
        }

        public Player(int health, int dmg, string weapon)
        {
            this.health = health;
            this.dmg = dmg;
            this.weapon = weapon;
        }
    }
}