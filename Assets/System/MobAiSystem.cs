using CastleDefender.Abilities;
using CastleDefender.Components;
using OOECS.Component.Location;
using OOECS.Entity;
using OOECS.system;
using UnityEngine;

namespace CastleDefender.System
{
    public class MobAiSystem : ISystem
    {
        public int Layer => (int)SystemLayers.ResolveAttack;
        
        public void Tick()
        {
            var currentTime = Time.time;
            foreach (var entity in EntityManager.QueryEntities(Query))
            {
                var abilityComp = entity.TryGet<AbilityComponent>();
                if (abilityComp.LastUsedTime + abilityComp.Value.Cooldown > currentTime)
                {
                    continue;
                }
                
                var target = entity.TryGet<TargetComponent>();
                if (target.Value == null)
                {
                    continue;
                }

                if (AbilityLogic.IsTargetInRange(abilityComp, target.Value.TryGet<WorldPositionComponent>()))
                {
                    AbilityLogic.ResolveAbility(abilityComp, target.Value);
                    entity.TryGet<SpeedComponent>().CurrentSpeed = Vector3.zero;
                }
            }
        }

        private static bool Query(Entity entity)
        {
            return entity.Has<AbilityComponent>();
        }
    }
}