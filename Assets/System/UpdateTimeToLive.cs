using CastleDefender.Components;
using OOECS.Entity;
using OOECS.system;
using UnityEngine;

namespace CastleDefender.System
{
    public class UpdateTimeToLive : ISystem
    {
        public int Layer => (int)SystemLayers.PostFrameDataUpdate;
        
        public void Tick()
        {
            var toDestroy = EntityUtils.GetSingletonEntity().TryGet<EntitiesToDestroy>();
            foreach (var entity in EntityManager.QueryEntities(Query))
            {
                var ttl = entity.TryGet<TimeToLiveComponent>();
                ttl.Value -= Time.deltaTime;
                if (ttl.Value <= 0)
                {
                    toDestroy.ToDestroy.Add(entity);
                }
            }
        }

        private static bool Query(Entity entity)
        {
            return entity.Has<TimeToLiveComponent>();
        }
    }
}