using OOECS.Component;

namespace CastleDefender.Components
{
    public class OwningTeamComponent : VersionedComponent<Teams>
    {
        public OwningTeamComponent(Teams value) : base(value)
        {
        }
    }

    public enum Teams
    {
        System = 0,
        Player = 1,
        Mobs = 2
    }
}