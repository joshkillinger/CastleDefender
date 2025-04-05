using OOECS.Component;

namespace CastleDefender.Components
{
    public class TimeToLiveComponent : Component<float>
    {
        public TimeToLiveComponent(float value) : base(value)
        {
        }
    }
}