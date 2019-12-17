using System;

namespace RPG
{
    public class Troll : Enemy, IHealAttack
    {
        public int dmg = 10;
        public int health = 75;

        public string weapon = "greatsword";
        public string name = "troll";

        public void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        public void Heal(int healthadd)
        {
            this.health += healthadd;
        }

        public Troll(int health, int dmg, string weapon)
        {
            this.health = health;
            this.dmg = dmg;
            this.weapon = weapon;
        }
    }
}