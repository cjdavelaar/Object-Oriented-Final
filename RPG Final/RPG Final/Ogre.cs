using System;

namespace RPG
{
    public class Ogre : Enemy, IHealAttack
    {
        public int dmg = 10;
        public int health = 75;

        public string weapon = "cleaver";
        public string name = "ogre";

        public void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        public void Heal(int healthadd)
        {
            this.health += healthadd;
        }

        public Ogre(int health, int dmg, string weapon)
        {
            this.health = health;
            this.dmg = dmg;
            this.weapon = weapon;
        }
    }
}