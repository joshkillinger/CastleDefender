using OOECS.Component;

namespace CastleDefender.Components
{
    public class BaseSpeedComponent : VersionedComponent<float>
    {
        public BaseSpeedComponent(float value) : base(value)
        {
        }
    }

    public class CurrentSpeedComponent : VersionedComponent<float>
    {
        public CurrentSpeedComponent(float value) : base(value)
        {
        }
    }
}