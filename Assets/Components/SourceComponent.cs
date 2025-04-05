using OOECS.Component;
using OOECS.Entity;

namespace CastleDefender.Components
{
    public class SourceComponent : Component<Entity>
    {
        public SourceComponent(Entity value) : base(value)
        {
        }
    }
}