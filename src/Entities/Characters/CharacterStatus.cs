

namespace Characters
{
    class CharacterStatus
    {
        public double health, maxHealth = 0;
        public double mana, maxMana = 0;
        public double minAtack = 3, maxAtack = 5;
        public double minHeal = 10, maxHeal = 20;
        public double minDamageReduction = 0, maxDamageReduction = 10;
        public double specialAtackManaCost = 250, specialAtackMultiplier = 1.5;

        public CharacterStatus(double maxHealth, double maxMana)
        {
            this.maxHealth = maxHealth;
            this.health = maxHealth;
            this.maxMana = maxMana;
            this.mana = maxMana;
        }

        public CharacterStatus(
            double maxHealth, double maxMana,
            double minAtack, double maxAtack,
            double minHeal, double maxHeal,
            double minDamageReduction, double maxDamageReduction,
            double specialAtackManaCost, double specialAtackMultiplier
            )
            :
            this(maxHealth, maxMana)
        {
            this.minAtack = minAtack;
            this.maxAtack = maxAtack;
            this.minHeal = minHeal;
            this.maxHeal = maxHeal;
            this.minDamageReduction = minDamageReduction;
            this.maxDamageReduction = maxDamageReduction;
            this.specialAtackManaCost = specialAtackManaCost;
            this.specialAtackMultiplier = specialAtackMultiplier;
        }

    }
}