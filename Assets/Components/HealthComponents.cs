using OOECS.Component;

namespace CastleDefender.Components
{
    public class MaxHealthComponent : VersionedComponent<int>
    {
        public MaxHealthComponent(int value) : base(value)
        {
        }
    }

    public class CurrentHealthComponent : VersionedComponent<int>
    {
        public CurrentHealthComponent(int value) : base(value)
        {
        }
    }
}