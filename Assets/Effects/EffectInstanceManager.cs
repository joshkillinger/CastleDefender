using CastleDefender.System;
using OOECS.PrefabProvider;
using OOECS.system;
using UnityEngine;

namespace CastleDefender.Effects
{
    public class EffectInstanceManager : MonoBehaviour, ISystem
    {
        public int Layer => (int)SystemLayers.Instantiate;

        private IEntityPrefabProvider _prefabProvider = null;
        
        public void Start()
        {
            _prefabProvider = GetComponent<IEntityPrefabProvider>();
            OOECS.system.Engine.Instance.Register(this);
        }
        
        public void Tick()
        {
            
        }

    }
}