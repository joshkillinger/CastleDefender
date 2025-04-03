using System;
using CastleDefender.Components;
using OOECS.Entity;
using OOECS.system;

namespace CastleDefender.System
{
    public class ApplyHealthModSystem : ISystem
    {
        public int Layer => (int)SystemLayers.ApplyHealthMod;
        
        public void Tick()
        {
            var toDestroy = EntityUtils.GetSingletonEntity().TryGet<EntitiesToDestroy>();
            
            foreach (var entity in EntityManager.QueryEntities(Query))
            {
                var health = entity.TryGet<HealthComponent>();
                
                health.Current += health.Modification;
                health.Modification = 0;
                health.Current = Math.Min(health.Max, health.Current);

                if (health.Current <= 0)
                {
                    toDestroy.ToDestroy.Add(entity);
                }
            }
        }

        private static bool Query(Entity entity)
        {
            return entity.TryGet<HealthComponent>(out var health) && health.Modification != 0;
        }
    }
}