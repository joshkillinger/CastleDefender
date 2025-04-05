using CastleDefender.Components;
using CastleDefender.System;
using OOECS.Entity;
using OOECS.PrefabProvider;
using OOECS.system;
using UnityEngine;

namespace CastleDefender.Mobs
{
    public class MobInstantiator : MonoBehaviour, ISystem
    {
        private MobSpawnTracking _spawnTracking;
        private MobSpawnTracking SpawnTracking => _spawnTracking ?? EntityUtils.GetSingletonEntity().TryGet<MobSpawnTracking>();

        private IEntityPrefabProvider _prefabProvider = null;

        public void Start()
        {
            _prefabProvider = GetComponent<IEntityPrefabProvider>();
            OOECS.system.Engine.Instance.Register(this);
        }

        public void Tick()
        {
            while (SpawnTracking.ToInstantiate.Count > 0)
            {
                var toSpawn = SpawnTracking.ToInstantiate[0];
                SpawnTracking.ToInstantiate.Remove(toSpawn);
                var instance = _prefabProvider.Get(toSpawn);
                instance.Data = toSpawn;
                instance.transform.parent = null;
            }
        }

        public int Layer => (int)SystemLayers.Instantiate;
    }
}