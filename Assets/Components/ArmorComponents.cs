using OOECS.Component;

namespace CastleDefender.Components
{
    public class BaseArmorComponent : VersionedComponent<int>
    {
        public BaseArmorComponent(int value) : base(value)
        {
        }
    }

    public class CurrentArmorComponent : VersionedComponent<int>
    {
        public CurrentArmorComponent(int value) : base(value)
        {
        }
    }
}