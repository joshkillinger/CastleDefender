using CastleDefender.Components;
using OOECS.Component.Location;
using OOECS.Entity;
using UnityEngine;

namespace CastleDefender.Abilities
{
    public static partial class AbilityLogic
    {
        public static void ResolveAbility(AbilityComponent abilityComponent, Entity targetValue)
        {
            abilityComponent.Value.Apply(abilityComponent, targetValue);
            abilityComponent.LastUsedTime = Time.time;
        }

        public static bool IsTargetInRange(AbilityComponent abilityComponent, WorldPositionComponent targetPosition)
        {
            var sourcePosition = abilityComponent.Entity.TryGet<WorldPositionComponent>().Value;
            return (targetPosition.Value - sourcePosition).magnitude <= abilityComponent.Value.Range;
        }
    }
}