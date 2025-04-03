using CastleDefender.Abilities;
using OOECS.Component;

namespace CastleDefender.Components
{
    public class AbilityComponent : Component<Ability>
    {
        public float LastUsedTime = 0;
        
        public AbilityComponent(Ability value) : base(value)
        {
        }
    }
}