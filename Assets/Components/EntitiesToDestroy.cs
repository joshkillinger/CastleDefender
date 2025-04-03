using System.Collections.Generic;
using OOECS.Component;
using OOECS.Entity;

namespace CastleDefender.Components
{
    public class EntitiesToDestroy : Component
    {
        public List<Entity> ToDestroy = new List<Entity>();
    }
}