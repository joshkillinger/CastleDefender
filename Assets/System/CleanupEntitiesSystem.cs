using CastleDefender.Components;
using OOECS.Entity;
using OOECS.system;

namespace CastleDefender.System
{
    public class CleanupEntitiesSystem : ISystem
    {
        public int Layer => (int)SystemLayers.Cleanup;
        
        public void Tick()
        {
            var toDestroy = EntityUtils.GetSingletonEntity().TryGet<EntitiesToDestroy>().ToDestroy;

            foreach (var entity in toDestroy)
            {
                EntityManager.DestroyEntity(entity);
            }
            
            toDestroy.Clear();
        }
    }
}