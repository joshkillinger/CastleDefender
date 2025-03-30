using CastleDefender.Components;
using jdkore.helpers;
using OOECS.Component;
using OOECS.Component.Location;
using OOECS.Entity;
using UnityEngine;

namespace CastleDefender
{
    public class GameSetup : Initializable
    {
        public override void Initialize()
        {
            EntityManager.Reset();
            InitSingletonEntity();
            InitBaseEntity();
        }

        private static void InitSingletonEntity()
        {
            var singletonEntity = EntityUtils.CreateSingletonEntity();
            singletonEntity.Add(new MobSpawnTracking());
            singletonEntity.Add(new OwningTeamComponent(Teams.System));
        }

        private static void InitBaseEntity()
        {
            var tower = EntityManager.CreateEntity();
            tower.Add(new NameComponent("Tower"));
            tower.Add(new WorldPositionComponent(new Vector3(-17, 0, 0)));
            tower.Add(new MaxHealthComponent(100));
            tower.Add(new CurrentHealthComponent(100));
            tower.Add(new OwningTeamComponent(Teams.Player));
        }
    }
}