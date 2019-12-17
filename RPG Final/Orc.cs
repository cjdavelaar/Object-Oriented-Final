using System;

namespace RPG
{
    public class Orc : Enemy, IHealAttack
    {
        new public int dmg = 10;
        new public int health = 75;

        new public string weapon = "battleaxe";
        new public string name = "orc";

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

        public Orc(int health, int dmg)
        {
            this.health = health;
            this.dmg = dmg;
        }
    }
}
