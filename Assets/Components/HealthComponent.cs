using OOECS.Component;

namespace CastleDefender.Components
{
    public class HealthComponent : VersionedComponent
    {
        public int Max;
        public int Current;
        public int Modification = 0;
        
        public HealthComponent(int value)
        {
            Max = value;
            Current = value;
            
        }

        public override string DebugString()
        {
            return $"{base.DebugString()}: Max {Max}, Current {Current}, Mod {Modification}";
        }
    }
}