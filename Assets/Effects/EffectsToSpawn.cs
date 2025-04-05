using System.Collections.Generic;
using OOECS.Component;
using OOECS.Entity;

namespace CastleDefender.Effects
{
    public class EffectsToSpawn : Component
    {
        public List<Entity> ToSpawn = new List<Entity>();
    }
}