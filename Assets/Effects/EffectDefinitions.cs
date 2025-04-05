using System.Linq;
using CastleDefender.Components;
using OOECS.Component;
using OOECS.Component.Location;
using OOECS.Entity;
using UnityEngine;

namespace CastleDefender.Effects
{
    public static class EffectDefinitions
    {
        private static void CreateMeleeAttackEffect(AbilityComponent source, Entity effect)
        {
            var sourcePos = source.Entity.TryGet<WorldPositionComponent>().Value;
            effect.TryGet<WorldPositionComponent>().Value = sourcePos;
            effect.Add(new TimeToLiveComponent(.5f));
            effect.Add(new AbilityComponent(source.Value));
        }

        private static void CreateRangedAttackEffect(AbilityComponent source, Entity effect)
        {
            var sourcePos = source.Entity.TryGet<WorldPositionComponent>().Value;
            effect.TryGet<WorldPositionComponent>().Value = sourcePos;
            effect.Add(new AbilityComponent(source.Value));

            if (source.Value.Tags.Contains("Beam"))
            {
                effect.Add(new TimeToLiveComponent(.5f));
            }
            else if (source.Value.Tags.Contains("Projectile"))
            {
                effect.Add(new SpeedComponent(Vector3.forward * 10));
            }
        }
        
        public static void CreateEffectEntity(AbilityComponent source, Entity target)
        {
            Entity effect = EntityManager.CreateEntity();
            effect.Add(new SourceComponent(source.Entity));
            if (target != null)
            {
                effect.Add(new TargetComponent(target));
            }
            effect.Add(new WorldPositionComponent(Vector3.zero));
            effect.Add(new AssetTagsComponent(source.Value.Tags.ToArray()));
            
            if (source.Value.Tags.Contains("Attack"))
            {
                if (source.Value.Tags.Contains("Melee"))
                {
                    CreateMeleeAttackEffect(source, effect);
                }
                else if (source.Value.Tags.Contains("Ranged"))
                {
                    CreateRangedAttackEffect(source, effect);
                }
            }
        }
    }
}