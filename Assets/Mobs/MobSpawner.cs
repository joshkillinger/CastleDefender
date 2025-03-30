using CastleDefender.Components;
using CastleDefender.System;
using OOECS.Component.Location;
using OOECS.Entity;
using OOECS.system;
using UnityEngine;

namespace Mobs
{
    public class MobSpawner : ISystem
    {
        private float spawnRate = 1f;
        private Vector3 offscreenSpawnPoint = new Vector3(20, 0);
        
        public void Tick()
        {
            var singleton = EntityUtils.GetSingletonEntity();
            var tracking = singleton.TryGet<MobSpawnTracking>();
            if (tracking.LastSpawnTime + spawnRate > Time.time)
            {
                return;
            }
            
            tracking.LastSpawnTime = Time.time;
            tracking.ToInstantiate.Add(GetMobToSpawn());
        }

        public int Layer => (int)SystemLayers.SpawnEntities;

        private Entity GetMobToSpawn()
        {
            var mob = EntityManager.CreateEntity();
            mob.Add(new BaseArmorComponent(1));
            mob.Add(new CurrentArmorComponent(1));
            mob.Add(new MaxHealthComponent(10));
            mob.Add(new CurrentHealthComponent(10));
            var speed = new SpeedComponent(Vector3.right, Vector3.right);
            speed.CurrentSpeed = speed.BaseSpeed * -1;
            mob.Add(speed);
            mob.Add(new WorldPositionComponent(offscreenSpawnPoint));
            mob.Add(new OwningTeamComponent(Teams.Mobs));

            return mob;
        }
    }
}