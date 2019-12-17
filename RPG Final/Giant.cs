using System;

namespace RPG
{
    public class Giant : Enemy, IHealAttack
    {
        new public int dmg = 8;
        new public int health = 90;

        new public string weapon = "club";
        new public string name = "giant";

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

        public Giant(int health, int dmg)
        {
            this.health = health;
            this.dmg = dmg;
        }
    }
}