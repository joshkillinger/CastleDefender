using CastleDefender.Components;
using OOECS.Component.Location;
using OOECS.Entity;
using OOECS.system;

namespace CastleDefender.System
{
    public class TargetingSystem : ISystem
    {
        public int Layer => (int)SystemLayers.Targeting;
        
        public void Tick()
        {
            foreach (var entity in EntityManager.QueryEntities(Query))
            {
                var target = entity.TryGet<TargetingComponent>();
                if (target.Value == null)
                {
                    target.Value = FindTarget(entity);
                }
            }
        }

        private static Entity FindTarget(Entity entity)
        {
            var currentTeam = entity.TryGet<OwningTeamComponent>().Value;
            var currentX = entity.TryGet<WorldPositionComponent>().Value.x;

            Entity closest = null;
            float closestX = float.MinValue;
            foreach (var candidate in EntityManager.QueryEntities(e => TargetQuery(e, currentTeam)))
            {
                var x = candidate.TryGet<WorldPositionComponent>().Value.x;
                if (x > currentX || x < closestX)
                {
                    continue;
                }

                currentX = x;
                closest = candidate;
            }

            return closest;
        }
        
        private static bool Query(Entity entity)
        {
            return entity.Has<TargetingComponent>();
        }

        private static bool TargetQuery(Entity entity, Teams sourceTeam)
        {
            if (!entity.TryGet<HealthComponent>(out var health) || health.Current == 0)
            {
                return false;
            }
            
            if (!entity.TryGet<OwningTeamComponent>(out var targetTeam))
            {
                return false;
            }

            return targetTeam.Value != sourceTeam;
        }
    }
    
}