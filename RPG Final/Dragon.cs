using System;

namespace RPG
{
    public class Dragon : Enemy, IHealAttack
    {
        new public int dmg = 10;
        new public int health = 75;

        new public string weapon = "fire";
        new public string name = "dragon";

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

        public Dragon(int health, int dmg)
        {
            this.health = health;
            this.dmg = dmg;
        }
    }
}