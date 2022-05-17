
using System;

namespace Characters
{
    class Cleric : Character
    {
        public Cleric(string name) :
        base(name: name,
        new CharacterStatus(
            maxHealth: 1200, maxMana: 600,
            minAtack: 100, maxAtack: 110,
            minHeal: 300, maxHeal: 350,
            minDamageReduction: 5, maxDamageReduction: 40,
            specialAtackManaCost: 25, specialAtackMultiplier: 1.05
            ))
        { }

        public override string ToString()
        {
            string characterDescription = base.ToString();
            characterDescription += @$"
            Type: Cleric
            ";
            return characterDescription;
        }

    }
}