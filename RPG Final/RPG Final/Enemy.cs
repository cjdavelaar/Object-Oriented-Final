using System;

namespace RPG
{
    public class Enemy
    {
        public int dmg = 10;
        public int health = 75;

        public string weapon = "sword";
        public string name = "enemy";

        public void TakeDamage(int damage)
        {
            this.health -= damage;
        }
    }
}