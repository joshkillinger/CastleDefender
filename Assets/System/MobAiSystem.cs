using CastleDefender.Components;
using OOECS.Component.Location;
using OOECS.Entity;
using OOECS.system;
using UnityEngine;

namespace CastleDefender.System
{
    public class MobAiSystem : ISystem
    {
        public int Layer => (int)SystemLayers.AiLogic;
        
        public void Tick()
        {
            var currentTime = Time.time;
            foreach (var entity in EntityManager.QueryEntities(Query))
            {
                var abilityComp = entity.TryGet<AbilityComponent>();
                var target = entity.TryGet<TargetingComponent>();
                if (target.Value?.TryGet<WorldPositionComponent>(out var targetPos) != true)
                {
                    
                }
                
                if (abilityComp.LastUsedTime + abilityComp.Definition.Cooldown > currentTime)
                {
                    continue;
                }
            }
        }

        private static bool Query(Entity entity)
        {
            return entity.Has<AbilityComponent>();
        }
    }
}