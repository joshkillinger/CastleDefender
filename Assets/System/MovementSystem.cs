using CastleDefender.Components;
using OOECS.Component.Location;
using OOECS.Entity;
using OOECS.system;
using UnityEngine;

namespace CastleDefender.System
{
    public class MoveEntities : ISystem
    {
        public int Layer => (int)SystemLayers.MoveEntities;
        
        public void Tick()
        {
            var deltaTime = Time.deltaTime;

            foreach (var entity in EntityManager.QueryEntities(Query))
            {
                var pos = entity.TryGet<WorldPositionComponent>();
                if (entity.TryGet(out SpeedComponent speed))
                {
                    pos.Value += speed.CurrentSpeed * deltaTime;
                }
            }
        }

        private static bool Query(Entity entity)
        {
            return entity.Has<WorldPositionComponent>();
        }
    }
}