using System;
using System.Linq;
using jdkore.helpers;
using OOECS.system;
using UnityEngine;

namespace CastleDefender.System
{
    public class SystemInitializer : Initializable
    {
        public override void Initialize()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var types = assemblies.SelectMany(x => x.GetTypes());
            var systems = types
                .Where(x => 
                    !x.IsInterface
                    && !x.IsAbstract
                    && typeof(ISystem).IsAssignableFrom(x)
                    && !typeof(MonoBehaviour).IsAssignableFrom(x));

            var engine = OOECS.system.Engine.Instance;
            foreach (var system in systems)
            {
                Debug.Log($"Initializing system {system.Name}");
                engine.Register((ISystem)Activator.CreateInstance(system));
            }
        }
    }
}