using System;

namespace RPG
{
    public class Skeleton : Enemy, IHealAttack
    {
        new public int dmg = 10;
        new public int health = 75;

        new public string weapon = "bow";
        new public string name = "skeleton";

        public void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        public void Heal(int healthadd)
        {
            this.health += healthadd;
        }

        public Skeleton(int health, int dmg, string weapon)
        {
            this.health = health;
            this.dmg = dmg;
            this.weapon = weapon;
        }

        public Skeleton(int health, int dmg)
        {
            this.health = health;
            this.dmg = dmg;
        }
    }
}