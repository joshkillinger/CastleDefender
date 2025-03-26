using System.Collections.Generic;
using OOECS.Component;
using OOECS.Entity;

namespace CastleDefender.Components
{
    public class MobSpawnTracking : Component
    {
        public float LastSpawnTime = -1f;
        public List<Entity> ToInstantiate = new List<Entity>();
        
        public MobSpawnTracking()
        {
        }
        
        public override string DebugString()
        {
            return $"MobSpawnTracking: Last {LastSpawnTime}, ToInstantiate {ToInstantiate.Count}";
        }
    }
}