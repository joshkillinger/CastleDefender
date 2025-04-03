using CastleDefender.Components;
using CastleDefender.System;
using OOECS.Entity;
using OOECS.system;
using UnityEngine;

namespace CastleDefender.Entities
{
    public class TowerEntityProvider : MonoBehaviour, ISystem
    {
        private Entity _data;
        private EntitiesToDestroy _toDestroy;
        
        private void Start()
        {
            _data = EntityManager.GetEntityById(1);
            GetComponent<EntityProvider>().Data = _data;
            EntityUtils.GetSingletonEntity().TryGet(out _toDestroy);
            OOECS.system.Engine.Instance.Register(this);
        }

        public void Tick()
        {
            if (_toDestroy.ToDestroy.Contains(_data))
            {
                Destroy(gameObject);
            }
        }

        public int Layer => (int)SystemLayers.DespawnEntities;
    }
}