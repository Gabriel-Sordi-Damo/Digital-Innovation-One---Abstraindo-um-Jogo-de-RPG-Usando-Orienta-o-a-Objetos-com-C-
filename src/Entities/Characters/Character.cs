using System;

namespace Characters
{

    abstract class Character
    {
        protected string name;
        protected CharacterStatus status;


        public Character(string name, CharacterStatus status)
        {
            this.name = name;
            this.status = status;
        }

        public override string ToString()
        {
            string characterDescription = @$"
            Name: {this.name} 
            HP: {Math.Truncate(this.status.health)}/{Math.Truncate(this.status.maxHealth)}
            Mana: {Math.Truncate(this.status.mana)}/{Math.Truncate(this.status.maxMana)}
            ";
            return characterDescription;
        }

        virtual public void Atack(Character opponent)
        {
            double atackMultiplier = BoostAtackWithMana();
            Random random = new Random();
            double damageAmount = Math.Clamp(
                random.NextDouble() * this.status.maxAtack * atackMultiplier,
                this.status.minAtack,
                this.status.maxAtack * atackMultiplier
            );

            opponent.Damage(damageAmount);

        }

        virtual public void SelfHeal()
        {

            Random random = new Random();
            double healAmount = Math.Clamp(
                 random.NextDouble() * this.status.maxHeal,
                 this.status.minHeal,
                 this.status.maxHeal
            );

            this.status.health = Math.Clamp(
                this.status.health + healAmount,
                0,
                this.status.maxHealth
            );
        }

        virtual public void RecoverMana()
        {
            Random random = new Random();
            double recoveredAmount = Math.Clamp(
                 random.NextDouble() * this.status.maxMana,
                 0,
                 this.status.maxMana
            );

            this.status.mana = Math.Clamp(
                this.status.mana + recoveredAmount,
                0,
                this.status.maxMana
            );
        }


        virtual public void Damage(double damageTaken)
        {

            Random random = new Random();
            double dammageReduction = Math.Clamp(
                 random.NextDouble() * this.status.maxDamageReduction,
                 this.status.minDamageReduction,
                 this.status.maxDamageReduction
            );

            damageTaken = damageTaken - dammageReduction;
            damageTaken = damageTaken < 0 ? 0 : damageTaken;

            this.status.health = Math.Clamp(
                this.status.health - damageTaken,
                0,
                this.status.maxHealth
                );
        }

        virtual protected double BoostAtackWithMana()
        {
            double atackMultiplier = 1;
            if (this.status.mana >= this.status.specialAtackManaCost)
            {
                atackMultiplier = this.status.specialAtackMultiplier;
                this.status.mana -= this.status.specialAtackManaCost;
            }
            return atackMultiplier;
        }
        public bool IsDead()
        {
            if (this.status.health <= 0)
                return true;
            return false;
        }

    }

}