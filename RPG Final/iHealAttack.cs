using System;

namespace RPG
{
    public interface IHealAttack
    {
        void TakeDamage(int damage);

        void Heal(int healthadd);
    }
}