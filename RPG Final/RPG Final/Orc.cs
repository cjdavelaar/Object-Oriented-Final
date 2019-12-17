using System;

namespace RPG
{
    public class Orc : Enemy, IHealAttack
    {
        public int dmg = 10;
        public int health = 75;

        public string weapon = "battleaxe";
        public string name = "orc";

        public void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        public void Heal(int healthadd)
        {
            this.health += healthadd;
        }

        public Orc(int health, int dmg, string weapon)
        {
            this.health = health;
            this.dmg = dmg;
            this.weapon = weapon;
        }

        public Orc(int health, int damage)
        {
            this.health = health;
            this.dmg = damage;
        }
    }
}
