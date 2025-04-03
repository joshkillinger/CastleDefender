using CastleDefender.Components;
using OOECS.Entity;

namespace CastleDefender.Abilities
{
    public static partial class AbilityLogic
    {
        public static void BasicAttack(AbilityComponent attack, Entity defender)
        {
            defender.TryGet<HealthComponent>().Modification -= ((Attack)attack.Value).Damage;
        }
    }
}