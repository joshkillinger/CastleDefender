using CastleDefender.Components;
using jdkore.helpers;
using OOECS.Entity;

namespace CastleDefender
{
    public class GameSetup : Initializable
    {
        public override void Initialize()
        {
            EntityManager.Reset();
            var singletonEntity = EntityUtils.CreateSingletonEntity();
            singletonEntity.Add(new MobSpawnTracking());
            singletonEntity.Add(new OwningTeamComponent(Teams.System));
        }
    }
}