using System;

namespace RPG
{
    public class Enemy
    {
        private int _dmg = 15;
        private int _health = 55;

        private string _weapon = "sword";
        private string _name = "enemy";

        public int dmg
        {
            get;
            set;
        }
        public int health
        {
            get;
            set;
        }

        public string weapon
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }
    }
}