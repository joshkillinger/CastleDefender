using OOECS.Component;
using OOECS.Entity;
using UnityEngine;

namespace CastleDefender.Components
{
    public class TargetComponent : Component<Entity>
    {
        public TargetComponent() : base(null)
        {
        }

        public TargetComponent(Entity entity) : base(entity)
        {
        }
    }
}