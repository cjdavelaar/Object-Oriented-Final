using System;

namespace RPG
{
    public class Giant : Enemy, IHealAttack
    {
        public int dmg = 8;
        public int health = 90;

        public string weapon = "club";
        public string name = "giant";

        public void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        public void Heal(int healthadd)
        {
            this.health += healthadd;
        }
        public Giant(int health, int dmg, string weapon)
        {
            this.health = health;
            this.dmg = dmg;
            this.weapon = weapon;
        }
    }
}