
using System;

namespace Characters
{
    class Tanker : Character
    {
        public Tanker(string name) :
        base(name: name,
        new CharacterStatus(
            maxHealth: 1450, maxMana: 300,
            minAtack: 100, maxAtack: 120,
            minHeal: 100, maxHeal: 200,
            minDamageReduction: 25, maxDamageReduction: 70,
            specialAtackManaCost: 25, specialAtackMultiplier: 1.3
            ))
        { }

        public override string ToString()
        {
            string characterDescription = base.ToString();
            characterDescription += @$"
                Type: Tanker
            ";
            return characterDescription;
        }

    }
}