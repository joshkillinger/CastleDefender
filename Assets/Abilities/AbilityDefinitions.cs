using System.Collections.Generic;

namespace CastleDefender.Abilities
{
    public static class AbilityDefinitions
    {
        private static Attack MeleeAttack = new Attack()
        {
            Cooldown = 1,
            Damage = 1,
            Name = "BasicMeleeAttack",
            Range = .1f,
            Tags = new List<string>() { "Attack", "Melee" },
            Apply = AbilityLogic.BasicAttack
        };
        
        public static Attack GetMeleeAttack()
        {
            return MeleeAttack;
        }
        
        private static Attack RangedAttack = new Attack()
        {
            Cooldown = 1,
            Damage = 1,
            Name = "BasicMeleeAttack",
            Range = 3f,
            Tags = new List<string>() { "Attack", "Ranged", "Beam" },
            Apply = AbilityLogic.BasicAttack
        };
        
        public static Attack GetRangedAttack()
        {
            return RangedAttack;
        }
    }
}