using System;
using System.Collections.Generic;
using CastleDefender.Components;
using OOECS.Entity;

namespace CastleDefender.Abilities
{
    public class Ability
    {
        public string Name;
        public float Cooldown;
        public float Range;
        public HashSet<string> Tags;
        public Action<AbilityComponent, Entity> Apply;

        public override string ToString() => Name;
    }
}