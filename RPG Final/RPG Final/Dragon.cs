using System;

namespace RPG
{
    public class Dragon : Enemy, IHealAttack
    {
        public int dmg = 10;
        public int health = 75;

        public string weapon = "fire";
        public string name = "dragon";

        public void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        public void Heal(int healthadd)
        {
            this.health += healthadd;
        }

        public Dragon(int health, int dmg, string weapon)
        {
            this.health = health;
            this.dmg = dmg;
            this.weapon = weapon;
        }
    }
}