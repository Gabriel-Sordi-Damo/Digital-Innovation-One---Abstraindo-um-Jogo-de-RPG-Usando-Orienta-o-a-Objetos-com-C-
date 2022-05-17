
using System;

namespace Characters
{
    class Mage : Character
    {
        public Mage(string name) :
        base(name: name,
        new CharacterStatus(
            maxHealth: 1000, maxMana: 1000,
            minAtack: 25, maxAtack: 350,
            minHeal: 0, maxHeal: 50,
            minDamageReduction: 0, maxDamageReduction: 25,
            specialAtackManaCost: 250, specialAtackMultiplier: 2.5
            ))
        { }

        public override string ToString()
        {
            string characterDescription = base.ToString();
            characterDescription += @$"
            Type: Mage
            ";
            return characterDescription;
        }

    }
}